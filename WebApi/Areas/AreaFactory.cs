using System;
using System.Collections.Generic;

namespace WebApi.Areas
{
    using WebApi.Abstract;

    /// <summary>
    /// AreaFactory
    /// </summary>
    public class AreaFactory : Factory
    {
        /// <summary>
        /// Product
        /// </summary>
        /// <returns></returns>
        protected override Product CreateProduct(List<string> pm)
        {
            return new Area(pm);
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