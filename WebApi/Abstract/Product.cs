using System;
using System.Net;

namespace WebApi.Abstract
{
    public abstract class Product
    {
        public abstract void execute();

        protected abstract string NewMethod(WebClient client);
    }
}