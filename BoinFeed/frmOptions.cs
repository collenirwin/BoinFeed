using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BoinFeed {
    public partial class frmOptions : Form {

        Form1 form;
        List<RadioButton> lstRad = new List<RadioButton>();

        public frmOptions(Form1 form) {
            InitializeComponent();
            this.form = form;

            lblVersion.Text = Constants.VERSION;
            lstRad.Add(radTitle);
            lstRad.Add(radTitleDesc);
            lstRad.Add(radTitleDescImage);

            try {
                lstRad[Properties.Settings.Default.niStyle].Checked = true;
            } catch { // Corrupt setting, selecting 2 by default
                Properties.Settings.Default.niStyle = 2;
                lstRad[2].Checked = true;
            }

            try {
                cdTheme.Color = Properties.Settings.Default.color;
            } catch { // Corrupt setting, setting default color
                cdTheme.Color = Color.FromArgb(255, 60, 60, 60);
            }
        }

        private void btnEditColor_Click(object sender, EventArgs e) {
            cdTheme.ShowDialog();
            form.setColorAll(cdTheme.Color);
        }

        private void btnResetColor_Click(object sender, EventArgs e) {
            Color clr = Color.FromArgb(255, 60, 60, 60);
            cdTheme.Color = clr;
            form.setColorAll(clr);
        }

        private void radTitle_CheckedChanged(object sender, EventArgs e) {
            form.setStyle(NewsItem.niStyle.title);
        }

        private void radTitleDesc_CheckedChanged(object sender, EventArgs e) {
            form.setStyle(NewsItem.niStyle.titleDesc);
        }

        private void radTitleDescImage_CheckedChanged(object sender, EventArgs e) {
            form.setStyle(NewsItem.niStyle.titleDescImage);
        }

        private void btnResetAllSettings_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to reset all of your settings back to their defaults? Note: you won't see an immediate change.", 
                "BoinFeed",
                MessageBoxButtons.YesNo)
                == DialogResult.Yes) {
                try {
                    Properties.Settings.Default.Reset();
                } catch {
                    MessageBox.Show(Constants.ERROR1, "BoinFeed - Error");
                }
            }
        }

        private void frmOptions_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                for (int x = 0; x < lstRad.Count; x++)
                    if (lstRad[x].Checked) {
                        Properties.Settings.Default.niStyle = x;
                        break;
                    }

                Properties.Settings.Default.color = cdTheme.Color;

                Properties.Settings.Default.Save();
            } catch {
                MessageBox.Show("Error 001: Settings file has likely been corrupted.", "BoinFeed - Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
