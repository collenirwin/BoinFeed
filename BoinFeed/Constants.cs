using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoinFeed {
    public static class Constants {
        public const string VERSION = "1.0.4";
        public const string UPDATE_URL = "http://www.plattsburghtabletennis.com/projs/update.xml";
        public const string DOWNLOAD_URL = "http://www.plattsburghtabletennis.com/collen/proj/boinfeed/";

        public const string ERROR1 = "Error 001: Settings file has likely been corrupted.";
        public const string ERROR2 = "Error 002: Cannot access files in directory. Possible permissions issue.";
        public const string ERROR3 = "Error 003: Failed to connect. Please verify that you are connected to the internet, and that all of your feeds are valid RSS.";

        public const string DEFAULT_URL = "http://www.npr.org/rss/rss.php?id=1019";
        public const string FILE_PATH = "feeds"; // Local file containing all feeds
        public const string IMG_PATH = "img\\"; // Local image directory
    }
}
