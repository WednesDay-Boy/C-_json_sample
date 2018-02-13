using System;

namespace Client
{
    using ApiPost;
    using ApiPostAuth;

    class Program
    {
        static void Main(string[] args)
        {
            // 一般的なポスト
            ApiPostJsonData p = new ApiPostJsonData();
            p.execute();

            // ベーシック認証つきのポスト
            ApiPostJsonAuth pa = new ApiPostJsonAuth();
            pa.execute();

        }
    }
}
