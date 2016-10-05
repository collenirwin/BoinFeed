using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace BoinFeed {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Version newVersion = null;
            XmlDocument xd = new XmlDocument();

            try {
                xd.Load(Constants.UPDATE_URL);

                XmlNode node = xd.SelectSingleNode("boinfeed/version");
                if (node != null) {
                    newVersion = new Version(node.InnerText);
                    if (newVersion.CompareTo(new Version(Constants.VERSION)) > 0)
                        if (MessageBox.Show("A new version is available. Would you like to download it?", "BoinFeed", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            Process.Start(Constants.DOWNLOAD_URL);
                }
            } catch { } // Fail silently; this isn't an important operation


            Application.Run(new Form1());
        }
    }
}
