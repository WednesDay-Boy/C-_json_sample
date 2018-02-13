using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Client.ApiPostAuth
{

    /// <summary>
    /// ApiPostJsonData
    /// WebClientを使って、Json文字列をPOSTするサンプル
    /// </summary>
    class ApiPostJsonAuth
    {
        private string url = "http://www.hogehoge.com/api2/";

        // ベーシック認証の id
        private string basic_id = "test";

        // ベーシック認証のパスワード
        private string basic_pass = "hogehoge";

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

            // ベーシック認証のヘッダーを作成
            // https://qiita.com/muro/items/8b9f5886c56f7b6afd3c
            var namePassword = string.Format("{0}:{1}", this.basic_id, this.basic_pass);
            var chars = Encoding.ASCII.GetBytes(namePassword);
            var base64 = Convert.ToBase64String(chars);
            webClient.Headers[HttpRequestHeader.Authorization] = "Basic " + base64;

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