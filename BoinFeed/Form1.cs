using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;

namespace BoinFeed {
    public partial class Form1 : Form {

        #region Vars

        bool failedRSS = false; // Token passed from BGW to indicate an error
        int[] refRate = { 300000, 600000, 1800000 }; // 5m, 10m, 30m
        List<string> lstImgs = new List<string>(); // Local image paths
        List<Feed> lstURLs = new List<Feed>(); // All feeds
        List<Feed> lstURLsSelected = new List<Feed>(); // Feeds selected in filter
        List<NewsItem> lstNews = new List<NewsItem>(); // List of all NewsItems
        Color niColor; // Color for all NewsItem and panel
        NewsItem.niStyle niStyle = NewsItem.niStyle.titleDescImage; // Style for all NewsItems

        #endregion

        #region Constructor & Form Related Methods

        public Form1() {
            InitializeComponent();
            load(); // Load all feeds into lstURLs and cboFilter
        }

        private void Form1_Load(object sender, EventArgs e) {
            setSettings(false); // Load settings
            pnlMain.Controls.Clear(); // Empty the panel
            runWorkerSafe(); // try to start downloading feeds
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            setSettings(true); // Save settings
        }

        private void setSettings(bool save, bool tried = false) {
            try {
                if (save) {
                    // Set all settings before closing
                    Properties.Settings.Default.location = this.Location;
                    if (this.WindowState != FormWindowState.Maximized) // Don't keep setting if maximized
                        Properties.Settings.Default.size = this.Size;
                    Properties.Settings.Default.maximized = (this.WindowState == FormWindowState.Maximized) ? true : false;

                    Properties.Settings.Default.refRate = cboRefRate.SelectedIndex;

                    Properties.Settings.Default.Save();
                } else {
                    // Init properties in accordance with settings
                    Point loc = Properties.Settings.Default.location;
                    this.Location = (Screen.PrimaryScreen.WorkingArea.Contains(loc)) ? loc : new Point(100, 100);
                    this.Size = Properties.Settings.Default.size;
                    this.WindowState = (Properties.Settings.Default.maximized) ? FormWindowState.Maximized : FormWindowState.Normal;
                    setColor(Properties.Settings.Default.color);
                    setStyle((NewsItem.niStyle)Properties.Settings.Default.niStyle);

                    cboRefRate.SelectedIndex = Properties.Settings.Default.refRate;
                    tmrRef.Interval = refRate[cboRefRate.SelectedIndex];
                }
            } catch {
                if (tried)
                    MessageBox.Show(Constants.ERROR1, "BoinFeed - Error");
                else {
                    try {
                        Properties.Settings.Default.Reset();
                    } catch { }
                    setSettings(save, true);
                }
            }
        }

        #endregion

        #region RSS Methods

        #region BGWs & Related Methods

        // Attempts to run bgwRSS, returns true if it can
        private bool runWorkerSafe() {
            if (!isTooRecent()) {
                if (!failedRSS && !bgwRSS.IsBusy) {
                    if (pnlMain.Controls.Count == 0) {
                        pnlMain.Controls.Add(pctLoad);
                        pctLoad.Show();
                    }

                    bgwRSS.RunWorkerAsync();
                    return true;
                }
            } else {
                pnlMain.Controls.Add(lblCountdown);
                lblCountdown.Show();
                pnlMain.Controls.SetChildIndex(lblCountdown, 0);
                tmrServerTimeout.Start();
            }
            return false;
        }

        // Main worker thread; downloads rss feeds and parses them, displays data in NewsItems
        private void bgwRSS_DoWork(object sender, DoWorkEventArgs e) {
            lstNews.Clear();
            lstImgs.Clear();

            foreach (Feed feed in lstURLs) {
                try {
                    XmlDocument xd = new XmlDocument();
                    xd.Load(feed.getUrl());

                    // So we can get thumbnails
                    XmlNamespaceManager manager = new XmlNamespaceManager(xd.NameTable);
                    manager.AddNamespace("media", "http://search.yahoo.com/mrss/");

                    XmlNodeList nodes = xd.SelectNodes("rss/channel/item", manager);

                    foreach (XmlNode node in nodes) {

                        // title
                        XmlNode subnode = node.SelectSingleNode("title");
                        string title = (subnode != null) ? subnode.InnerText.Trim() : "No Title";

                        // link to article
                        subnode = node.SelectSingleNode("link");
                        string link = (subnode != null) ? subnode.InnerText.Trim() : "";

                        // desc
                        subnode = node.SelectSingleNode("description");
                        string description = (subnode != null) ? subnode.InnerText.Trim() : "No Description";

                        // Creates a new RssParser object with the description, which trims out tags and keeps links in a list
                        //RssParser rp = new RssParser(description);

                        // date published
                        subnode = node.SelectSingleNode("pubDate");
                        string dateString = (subnode != null) ? subnode.InnerText.Trim() : "";

                        // link to image
                        string imagePath = "";

                        subnode = node.SelectSingleNode("media:thumbnail", manager);
                        if (subnode == null) {
                            subnode = node.SelectSingleNode("media:content/media:thumbnail", manager);
                        }

                        if (subnode != null && subnode.Attributes != null && subnode.Attributes["url"] != null)
                            imagePath = subnode.Attributes["url"].Value;

                        if (imagePath != "") {
                            try {
                                string imagePathTemp = imagePath; // copy path into temp var

                                if (localImagePathExists(imagePath)) // Local copy exists
                                    imagePath = Constants.IMG_PATH + getFileName(imagePath);
                                else { // download local copy
                                    using (WebClient client = new WebClient())
                                        client.DownloadFile(imagePath, Constants.IMG_PATH + getFileName(imagePath));

                                    if (localImagePathExists(imagePath)) // local copy exists now
                                        imagePath = Constants.IMG_PATH + getFileName(imagePath);
                                    else // failed somehow
                                        imagePath = ""; // don't use image
                                }
                            } catch {
                                imagePath = ""; // don't use image
                            }
                        }

                        if (imagePath != "")
                            lstImgs.Add(imagePath);

                        DateTime date = DateTime.Now; // Initialized date to the current date

                        if (dateString != "") // Attempt to parse the publish date, set date to it
                            DateTime.TryParse(dateString.Substring(4, dateString.Length - 11), out date);

                        // Add a new NewsItem to the list with all the data we just parsed
                        lstNews.Add(new NewsItem(
                            title,
                            link,
                            date,
                            feed,
                            description,
                            (imagePath != "") ? Image.FromFile(imagePath) : null)
                            );
                    }

                    lstNews.Sort(new Comparison<NewsItem>(compareDates));
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException + "\n\n" + ex.Data); // TESTING
                    failedRSS = true;
                }
            }
        }

        // bgwRSS finished or errored
        private void bgwRSS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (failedRSS) {
                MessageBox.Show(Constants.ERROR3, "BoinFeed - Error");

                if (pnlMain.Controls.Contains(pctLoad)) // Get rid of the loading gif
                    pnlMain.Controls.Clear();

                pnlMain.Controls.Add(btnReconnect); // Add reconnect button
                btnReconnect.Show();
                pnlMain.Controls.SetChildIndex(btnReconnect, 0); // make it the first control

                failedRSS = false; // Reset failed bool
            } else {
                pnlMain.Controls.Clear();
                foreach (NewsItem ni in lstNews) {
                    ni.setStyle(niStyle);
                    ni.setColor(niColor);
                    pnlMain.Controls.Add(ni);
                }

                cboFilter.Show();

                Properties.Settings.Default.lastUpdate = DateTime.Now;
                if (!bgwPurge.IsBusy) // Purge image directory to save space
                    bgwPurge.RunWorkerAsync();
            }
            tmrRef.Start();
        }

        // Compares the dates of NewsItems for use with sorting
        private int compareDates(NewsItem a, NewsItem b) {
            DateTime dB = b.date; // Avoids calling the CompareTo method directly
            return dB.CompareTo(a.date);
        }

        // Runs the worker on a specified interval if it can - Main Timer
        private void tmrRef_Tick(object sender, EventArgs e) {
            runWorkerSafe();
        }

        private void bgwPurge_DoWork(object sender, DoWorkEventArgs e) {
            purgeImageDir();
        }

        // Attempts to delete all images in the img directory that aren't in use.
        private bool purgeImageDir() {
            try {
                if (dirMade(Constants.IMG_PATH)) {
                    DirectoryInfo di = new DirectoryInfo(Constants.IMG_PATH);

                    foreach (FileInfo fi in di.GetFiles())
                        if (!lstImgs.Contains(Constants.IMG_PATH + fi.Name)) // Not in list
                            try {
                                File.Delete(fi.FullName); // Delete it
                            } catch { } // Fail silently. It isn't a big deal if a file fails to delete here.

                    return true;
                }

                return false;
            } catch {
                return false;
            }
        }

        #endregion

        #region IO & Image Handling

        // checks if directory exists, tries to create if it doesn't, returns false if it fails to create
        private bool dirMade(string path) {
            if (Directory.Exists(path))
                return true;
            else {
                try {
                    Directory.CreateDirectory(path);
                    return true;
                } catch {
                    MessageBox.Show(Constants.ERROR2, "BoinFeed - Error");
                    return false;
                }
            }
        }

        // returns file name within a specified path, empty string if not valid path
        private string getFileName(string path) {
            try {
                return (path.Contains("/")) // linux/web path format (/)
                ? path.Substring(path.LastIndexOf("/") + 1)
                : (path.Contains("\\") // windows path format (\)
                ? path.Substring(path.LastIndexOf("\\") + 1)
                : "");
            } catch {
                return "";
            }
        }

        // Checks the img directory for the same image (by name only), returns true if local file found
        private bool localImagePathExists(string path) {
            string name = getFileName(path);
            string localPath = Constants.IMG_PATH + name;

            if (dirMade(Constants.IMG_PATH)) // Check if image path exists, make it if it doesn't
                return File.Exists(localPath);

            return false;
        }

        // Loads the current rss feed urls from the file into the array
        public void load(bool runWorker = false) {
            if (File.Exists(Constants.FILE_PATH) || FeedFileParser.initFeedFile()) 
                lstURLs = FeedFileParser.parse(Constants.FILE_PATH);

            // Load all feeds into the filter control
            cboFilter.lst.Items.Clear();
            foreach (Feed f in lstURLs)
                cboFilter.lst.Items.Add(f.getName());

            cboFilter.selectAll();

            if (runWorker) { // ReRun the worker thread to update the news feed
                tmrRef.Stop();
                runWorkerSafe();
                tmrRef.Start();
            }
        }

        #endregion

        #region Timeout Handling

        // Compares the time the last form instance was closed with now, returns true if less than 25secs ago
        private bool isTooRecent() {
            try {
                if (getSecondsLeft() > 0)
                    return true;
            } catch { } // Fail silently, return false
            return false;
        }

        private int getSecondsLeft() {
            DateTime date;
            return (DateTime.TryParse(Properties.Settings.Default.lastUpdate.ToString(), out date))
                ? 25 - Convert.ToInt32((DateTime.Now - date).TotalSeconds)
                : 0;
        }

        // Tries to run the worker after a 20 second timeout, stops timer
        private void tmrServerTimeout_Tick(object sender, EventArgs e) {
            int secs = getSecondsLeft();
            lblCountdown.Text = lblCountdown.Tag.ToString() + secs.ToString() + "...";

            if (secs <= 0) {
                pnlMain.Controls.Clear();
                runWorkerSafe();
                tmrServerTimeout.Stop();
            }
        }

        #endregion

        #endregion

        #region UI Methods

        #region Form Dragging (user32.dll)

        // No real benefit now, but may be useful in later versions

        // For WndProc
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void btnEditFeeds_Click(object sender, EventArgs e) {
            frmEditFeeds f = new frmEditFeeds(this);
            f.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e) {
            frmOptions f = new frmOptions(this);
            f.ShowDialog();
        }

        private void setColor(Color color) {
            pnlMain.BackColor = color;
            foreach (Control c in pnlMain.Controls) {
                NewsItem ni = c as NewsItem;
                if (ni != null)
                    ni.setColor(color);
            }
        }

        private void cboRefRate_SelectedIndexChanged(object sender, EventArgs e) {
            // Change timer's rate to the new selected refresh rate
            tmrRef.Interval = refRate[cboRefRate.SelectedIndex];
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) {
            // Hack to get rid of focus
            btnFocusGrab.Focus();
        }

        private void pnlMain_MouseEnter(object sender, EventArgs e) {
            // Make the panel scroll with the mouse wheel
            pnlMain.Focus();
        }

        private void pnlMain_Scroll(object sender, ScrollEventArgs e) {
            Application.DoEvents(); // Helps with screen tearing on scroll
        }

        // Setting color of panel and all NewsItems
        public void setColorAll(Color color) {
            this.niColor = color;

            pnlMain.BackColor = color;
            foreach (NewsItem ni in pnlMain.Controls)
                ni.setColor(color);
        }

        // Setting the style of all NewsItems
        public void setStyle(NewsItem.niStyle style) {
            this.niStyle = style; // Set global style

            foreach (NewsItem ni in lstNews)
                ni.setStyle(style);
        }

        private void btnReconnect_Click(object sender, EventArgs e) {
            runWorkerSafe();
        }

        // Changing the filter
        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) {
            // Apply the filter to the NewsItems in the panel
            foreach (NewsItem ni in lstNews)
                ni.Visible = (cboFilter.lst.CheckedItems.Contains(ni.feed.getName())) ? true : false;
        }

        #endregion
    }
}
