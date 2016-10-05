using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace BoinFeed {
    public partial class frmEditFeeds : Form {

        int editIndex = 0;
        bool isChanged = false;
        Form1 form;

        public frmEditFeeds(Form1 form) {
            InitializeComponent();
            this.form = form;

            if (File.Exists(Constants.FILE_PATH) || FeedFileParser.initFeedFile())
                lstMain.Items.AddRange(FeedFileParser.parse(Constants.FILE_PATH).ToArray());     
        }

        private void save() {
            using (StreamWriter W = File.CreateText(Constants.FILE_PATH))
                foreach (Feed f in lstMain.Items)
                    W.WriteLine(f.fileFormat());
        }

        private bool safeAddItem(string url, string name) {
            string trimURL = url.Trim(),
                trimName = name.Trim();

            if (trimURL != "" && trimName != "") {
                try {
                    XmlDocument xd = new XmlDocument();
                    xd.Load(trimURL);
                } catch {
                    MessageBox.Show("Could not parse " + trimURL + " as RSS. Perhaps the file could not be found.", "BoinFeed");
                    return false;
                }

                lstMain.Items.Add(new Feed(trimURL, trimName));
                txtURL.Text = "";
                txtName.Text = "";
                isChanged = true;
                return true;
            }

            MessageBox.Show("Please make sure to fill out both fields (url and name).", "BoinFeed");
            return false;
        }

        private void btnAddFeed_Click(object sender, EventArgs e) {
            safeAddItem(txtURL.Text, txtName.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (lstMain.SelectedIndex != -1) {
                lstMain.Items.RemoveAt(lstMain.SelectedIndex);
                isChanged = true;
            }
        }

        private void frmEditFeeds_FormClosing(object sender, FormClosingEventArgs e) {
            save();
            if (isChanged)
                form.load(true);
        }

        private void btnEditName_Click(object sender, EventArgs e) {
            if (lstMain.SelectedIndex != -1) {
                if (btnEditName.Text == "Cancel") {
                    btnEditName.Text = "Edit Item";
                    btnAddFeed.Show();
                    btnDoneEdit.Hide();

                    txtURL.Text = "";
                    txtName.Text = "";
                } else {
                    editIndex = lstMain.SelectedIndex;
                    btnEditName.Text = "Cancel";
                    btnAddFeed.Hide();
                    btnDoneEdit.Show();

                    Feed f = lstMain.SelectedItem as Feed;
                    txtURL.Text = f.getUrl();
                    txtName.Text = f.getName();
                }
            } else
                MessageBox.Show("Please select a feed to edit", "BoinFeed");
        }

        private void btnDoneEdit_Click(object sender, EventArgs e) {
            lstMain.Items.RemoveAt(editIndex);
            if (!safeAddItem(txtURL.Text, txtName.Text))
                return;

            btnEditName.Text = "Edit Item";
            btnDoneEdit.Hide();
            btnAddFeed.Show();
        }
    }
}
