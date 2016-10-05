namespace BoinFeed {
    public class Feed {

        string url;
        string name;

        public Feed(string url, string name) {
            this.url = url;
            this.name = name;
        }

        public string getUrl() {
            return this.url;
        }

        public void setUrl(string url) {
            this.url = url;
        }

        public string getName() {
            return this.name;
        }

        public void setName(string name) {
            this.name = name;
        }

        public string fileFormat() {
            return this.name + "|" + this.url;
        }

        public override string ToString() {
            return "name: " + this.name + " url: " + this.url;
        }
    }
}
