using Newtonsoft.Json;
using System;
using System.Net;
using System.Collections.Generic;

namespace WebApi.Areas
{

    using WebApi.Abstract;

    public class Area : Product 
    {

        private string requestUrl = "http://geoapi.heartrails.com/api/json?method=getAreas";

        internal Area(List<string> pm)
        {

        }

        public override void execute()
        {
            var client = new WebClient()
            {
                // ANSIで帰ってくるので、UTF8でエンコーディングする
                Encoding = System.Text.Encoding.UTF8
            };

            string json = NewMethod(client);
            var contents = JsonConvert.DeserializeObject(json);

            Console.Write(contents);
        }

        protected override string NewMethod(WebClient client)
        {
            return client.DownloadString(requestUrl);
        }
    }
}