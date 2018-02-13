using System;

namespace Client.ApiPost
{
    public class RequestDataStructure
    {
        public string name { get; set; }
        public int age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">ユーザー名</param>
        /// <param name="age">年齢</param>
        public RequestDataStructure(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}