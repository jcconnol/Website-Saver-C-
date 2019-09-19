using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Website_Saver3
{
    class WebService
    {
        private string url = "";
        private string fileLocation = "";
        private string html = "";

        public WebService(string url, string fileLocation)
        {
            this.url = url;
            this.fileLocation = fileLocation;
        }

        public void GetHtml(string url)
        {
            using (WebClient client = new WebClient())
            {
                html = client.DownloadString(LandingForm.url);
            }
        }

        public void SaveHtmlToFile(string html)
        {
            TextWriter txt = new StreamWriter(fileLocation + url + ".html");
            txt.Write(html);
            txt.Close();
        }

        public List<String> Execute()
        {
            this.GetHtml(this.url);
            this.SaveHtmlToFile(this.html);
            return getURLs(url);
        }

        public List<string> getURLs(string inputUrl)
        {
            List<string> foundUrls = new List<string>();
            string[] separator = { "href=" };

            inputUrl.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            return foundUrls;
        }
    }
}
