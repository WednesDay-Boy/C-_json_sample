using System;
using System.Linq;
using System.Collections.Generic;

namespace WebApi.Abstract
{

    /// <summary>
    /// Factory
    /// Factory MethodパターンのCreater
    /// </summary>
    public abstract class Factory
    {
        public Product Create(List<string> parameters)
        {
            Product p = CreateProduct(parameters);
            RegisterProduct(p);
            return p;
        }
        protected abstract Product CreateProduct(List<string> parameters);
        protected abstract void RegisterProduct(Product product);
    }

}