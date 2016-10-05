using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BoinFeed {
    public partial class NewsItem : UserControl {

        private string title;
        private string description;
        private Image image;
        private RssParser rs;
        private niStyle style;

        public string link = "";
        public DateTime date;
        public Feed feed;

        public enum niStyle {
            title,
            titleDesc,
            titleDescImage
        }

        public NewsItem(string title, string link, DateTime date, Feed feed, string description = "", Image image = null) {
            InitializeComponent();

            // Minumum
            this.title = title;
            this.linkButton.Text = title;
            this.link = link;
            this.date = date;
            this.feed = feed;
            this.description = description;
            this.image = image;

            // Title & Description
            if (description != "") {
                rs = new RssParser(description);

                this.desc.Text = rs.description;

                if (rs.links.Count > 0)
                    addLinksToggle("+");

            } else { // Get rid of description label
                this.desc.Hide();
                //this.table.RowCount = 2;
            }

            // Title, Description, & Image
            if (image != null) {
                try {
                    this.imageBox.Image = image;
                    this.imageBox.MinimumSize = (image.Height > 126) ? new Size(0, 126) : new Size(0, image.Height);
                } catch {
                    this.imageBox.Hide();
                }
            } else { // Get rid of picturebox
                this.imageBox.Hide();
                //this.table.RowStyles[1].Height = 0;
            }
        }

        private void linkButton_Click(object sender, System.EventArgs e) {
            try {
                if (this.link != "")
                    Process.Start(link);
                else
                    MessageBox.Show("Error 004: No link was found.", "BoinFeed - Error");
            } catch {
                MessageBox.Show("Error 005: Failed to launch link; could be broken.", "BoinFeed - Error");
            }
        }

        // Adds the Links toggle button to the description
        private void addLinksToggle(string button) {
            this.desc.Links.Clear(); // clear all links
            this.desc.Text = rs.description; // reset description
            this.desc.Text += "\r\nLinks[" + button + "]"; // add link button text
            this.desc.Links.Add(this.desc.Text.Length - button.Length - 1, button.Length, button); // hook up the link
        }

        private void desc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (e.Link.LinkData.ToString() == "+") {
                addLinksToggle("-");
                int x = 0;
                this.desc.Text += "\r\n";
                foreach (string s in rs.links) {
                    string newS = s;
                    if (newS.Length > 32)
                        newS = newS.Substring(0, 28) + "...";
                    this.desc.Text += newS;
                    this.desc.Links.Add(new LinkLabel.Link(this.desc.Text.Length - newS.Length, newS.Length, s));
                    if (x++ != rs.links.Count - 1)
                        this.desc.Text += ", ";
                }
            } else if (e.Link.LinkData.ToString() == "-") {
                addLinksToggle("+");
            } else {
                try {
                    Process.Start(e.Link.LinkData.ToString());
                } catch {
                    MessageBox.Show("Error 005: Failed to launch link; could be broken.", "BoinFeed - Error");
                }
            }
        }

        public void setColor(Color color) {
            this.BackColor = color;
            this.table.BackColor = color;
            this.imageBox.BackColor = color;
            this.desc.BackColor = color;
            this.desc.ForeColor = ((color.R + color.G + color.B) < 382.5) // Midpoint between all 0 and all 255
                ? Color.FromArgb(255, 200, 200, 200)
                : Color.FromArgb(255, 55, 55, 55);     
        }        
        
        public void setStyle(niStyle style) {
            if (style == niStyle.title) {  
                this.desc.Hide();
                this.imageBox.Hide();
            } else if (style == niStyle.titleDesc) {
                this.desc.Show();
                this.imageBox.Hide();
            } else { // titleDescImage
                this.desc.Show();
                this.imageBox.Show();
            }

            this.style = style;
        }

        public niStyle getStyle() {
            return this.style;
        }
    }
}
