using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BoinFeed {
    public static class FeedFileParser {

        public static List<Feed> parse(string path) {
            List<Feed> lst = new List<Feed>();
            
            try {
                using (StreamReader R = File.OpenText(path)) {
                    while (R.Peek() != -1) {
                        string s = R.ReadLine().Trim();
                        if (s != "") {
                            string name = s.Substring(0, s.IndexOf("|"));
                            string url = s.Substring(s.IndexOf("|") + 1);

                            lst.Add(new Feed(url, name));
                        }
                    }
                }
            } catch {
                lst.Add(new Feed("error", "error"));
            }

            return lst;
        }

        public static bool initFeedFile() {
            try {
                if (!File.Exists(Constants.FILE_PATH))
                    using (StreamWriter W = File.CreateText(Constants.FILE_PATH))
                        W.WriteLine(new Feed(Constants.DEFAULT_URL, "Default").fileFormat());

                return true;
            } catch {
                MessageBox.Show(Constants.ERROR2, "BoinFeed - Error");
                return false;
            }
        }
    }
}
