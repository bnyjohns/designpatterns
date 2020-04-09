using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.SimpleFactoryDemo
{
    class SimpleFactoryDemo
    {
        //static void Main()
        //{
        //    AbstractProduct product2 = ProductFactory.GetProduct("ProductTwo");            
        //}
    }
    
    public class ProductFactory
    {
        public static AbstractProduct GetProduct(string productName)
        {
            AbstractProduct product = null;
            switch (productName)
            {
                case "ProductOne":
                    product = new Product1();
                    break;

                case "ProductTwo":
                    product = new Product2();
                    break;

                default:
                    product = null;
                    break;
            }
            return product;
        }
    }    

    public abstract class AbstractProduct
    {
        public abstract string ProductName { get; set; }
        public abstract int ProductId { get; set; }
    }

    public class Product1 : AbstractProduct
    {        
        public override int ProductId { get; set; }
        public override string ProductName { 
            get
        {
                return "ProductOne";
        }
            set{
            }
        }

    }

    public class Product2 : AbstractProduct
    {
        public override int ProductId { get; set; }
        public override string ProductName { 
        get
        {
                return "ProductTwo";
        }
        set{
        }
        }
       
    }
}
