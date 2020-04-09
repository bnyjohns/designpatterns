using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.AbstractMethodDemo
{
    class AbstractMethodDemo
    {
        //static void Main()
        //{
        //    AbstractFactory productFactory1 = new ConcreteFactory1();
        //    AbstractProduct product1 = productFactory1.GetProduct();
        //}
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProduct GetProduct();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProduct GetProduct()
        {
            return new Product1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProduct GetProduct()
        {
            return new Product2();
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
        public override string ProductName
        {
            get
            {
                return "ProductOne";
            }
            set
            {
            }
        }

    }

    public class Product2 : AbstractProduct
    {
        public override int ProductId { get; set; }
        public override string ProductName
        {
            get
            {
                return "ProductTwo";
            }
            set
            {
            }
        }

    }
}
