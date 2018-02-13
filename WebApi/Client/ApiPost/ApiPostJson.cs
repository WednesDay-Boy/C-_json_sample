using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Client.ApiPost
{

    /// <summary>
    /// ApiPostJsonData
    /// WebClientを使って、Json文字列をPOSTするサンプル
    /// </summary>
    class ApiPostJsonData
    {
        private string url = "http://www.hogehoge.com/api1/";
        
        /// <summary>
        /// execute
        /// postの実行
        /// </summary>
        public  void execute()
        {

            WebClient client = this.GenerateWebClient();
            string content = this.GenerateContent();
            string response = client.UploadString(new Uri(this.url), "POST", content); 

            Console.WriteLine(response);
        }

        /// <summary>
        /// GenerateWebClient
        /// WebClientの生成
        /// </summary>
        /// <returns>WebClient</returns>
        private WebClient GenerateWebClient()
        {
            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json;charset=UTF-8";
            webClient.Headers[HttpRequestHeader.Accept] = "application/json";
            webClient.Encoding = Encoding.UTF8;

            return webClient;
        }

        /// <summary>
        /// GenerateContent
        /// json文字列の生成。RequstDataStructureクラスを利用
        /// </summary>
        /// <returns></returns>
        public string GenerateContent()
        {
            RequestDataStructure ds = new RequestDataStructure("watanabe", 35);

            return JsonConvert.SerializeObject(ds);
        }
    }
}