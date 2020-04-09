using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.SingletonDemo
{
    class SingletonDemo
    {
        //static void Main()
        //{
        //    ProductCatalog instance = ProductCatalog.Instance;
        //}
    }

    class ProductCatalog
    { 

        private ProductCatalog()
        {

        }
        static ProductCatalog()
        {

        }
        private static ProductCatalog _productCatalog = null;

        public static ProductCatalog Instance
        {
            get
            {
                if (_productCatalog == null)
                    _productCatalog = new ProductCatalog();
                return _productCatalog;
            }
        }
    }
}
