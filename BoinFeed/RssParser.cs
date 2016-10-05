using System.Collections.Generic;

namespace BoinFeed {
    class RssParser {
        public string description;
        public List<string> links = new List<string>();

        public RssParser(string description) {
            while (true) {
                int startTag = 0, endTag = 0;

                try {
                    startTag = description.IndexOf("<", startTag);
                    endTag = description.IndexOf(">", startTag);
                } catch {
                    break;
                }

                if (endTag > startTag) { // Both exist and in the correct place
                    string tag = description.Substring(startTag, endTag - startTag);
                    if (tag.Contains("a href")) {
                        try {
                            // Link url within <a>
                            tag = tag.Replace("'", "\"").Replace(" ", "").ToLower();
                            int hrefPos = tag.IndexOf("ahref");
                            this.links.Add(tag.Substring(hrefPos + 7, tag.IndexOf("\"", hrefPos + 7) - hrefPos - 7));
                        } catch { } // Fail silently; we're not going to try to parse it if the tag has bad syntax
                    }
                    description = description.Remove(startTag, endTag - startTag + 1);
                } else
                    break;
            }
            this.description = (description.Trim() != "") ? description : "No Description";
        }
    }
}
