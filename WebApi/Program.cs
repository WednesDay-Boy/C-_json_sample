using System;
using System.Collections.Generic;

namespace WebApi
{
    using WebApi.Abstract;
    using WebApi.Areas;
    using WebApi.Prefectures;

    class Program
    {
        static void Main(string[] args)
        {   
            // area情報の取得
            //List<string> pm = new List<string>();
            //pm.Add("関東");

            //AreaFactory factory = new AreaFactory();
            //Product result = factory.Create(pm);
            //result.execute();

            // 都道府県情報の取得
            List<string> pm = new List<string>();
            pm.Add("関東");
            
            PrefectureFactory factory = new PrefectureFactory();
            Product result = factory.Create(pm);
            result.execute();
        }
    }
}
