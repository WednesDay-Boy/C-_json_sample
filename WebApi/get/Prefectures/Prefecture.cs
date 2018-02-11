using Newtonsoft.Json;
using System;
using System.Net;
using System.Collections.Generic;

namespace WebApi.Prefectures
{

    using WebApi.Abstract;

    public class Prefecture : Product 
    {

        private string requestUrl = "http://geoapi.heartrails.com/api/json?method=getPrefectures";

        internal Prefecture(List<string> pm)
        {
            // 文字列の結合を行って、リクエスするURLを生成する
            this.requestUrl += "&area=" + pm[0];
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