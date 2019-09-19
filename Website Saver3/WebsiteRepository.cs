using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Saver3
{
    class WebsiteRepository
    {
        private Dictionary<string, string> filesMade;

        WebsiteRepository(WebService webService)
        {

        }

        public void Excecute()
        {

        }
        


        public void AllWebsiteDownload()
        {

            //add first website to filesmade and then download
            //all links in that page with same domain name are then run
            //each of those domains are saved into filesmade

            //do
            //{
                WebService webservice = new WebService(LandingForm.url, LandingForm.directory);
            //} while ();
        }

    }
}
