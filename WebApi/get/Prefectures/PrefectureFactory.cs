using System;
using System.Collections.Generic;

namespace WebApi.Prefectures 
{
    using WebApi.Abstract;

    /// <summary>
    /// AreaFactory
    /// </summary>
    public class PrefectureFactory : Factory
    {
        /// <summary>
        /// Product
        /// </summary>
        /// <returns></returns>
        protected override Product CreateProduct(List<string> pm)
        {
            return new Prefecture(pm);
        }

        /// <summary>
        /// RegisterProduct
        /// </summary>
        /// <param name="product"></param>
        protected override void RegisterProduct(Product product)
        {

        }
    } 
}