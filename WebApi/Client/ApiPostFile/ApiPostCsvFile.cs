using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Client.ApiPostFile
{

    /// <summary>
    /// ApiPostJsonData
    /// WebClientを使って、fileをアップロードするサンプル
    /// </summary>
    class ApiPostCsvFile
    {
        private string url = "http://www.hogehoge.com/api3/";

        // ベーシック認証の id
        private string basic_id = "test";

        // ベーシック認証のパスワード
        private string basic_pass = "hogehoge";

        // アップロードするファイルのパス
        private string file_path = "ApiPostFile/upload.csv";

        /// <summary>
        /// execute
        /// postの実行
        /// </summary>
        public void execute()
        {

            WebClient client = this.GenerateWebClient();
            byte[] response = client.UploadFile(new Uri(this.url), this.file_path); 

            Console.WriteLine(Encoding.ASCII.GetString(response));
        }

        /// <summary>
        /// GenerateWebClient
        /// WebClientの生成
        /// </summary>
        /// <returns>WebClient</returns>
        private WebClient GenerateWebClient()
        {
            WebClient webClient = new WebClient();
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
    }
}