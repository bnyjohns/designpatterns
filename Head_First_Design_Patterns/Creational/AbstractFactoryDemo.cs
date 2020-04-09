using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.AbstractFactoryDemo
{
    class AbstractFactoryDemo
    {
        //static void Main()
        //{
        //    Client client = new Client(new ConcreteFactory1());
        //    client.DoWhatEverWithProductAAndProductB();
        //}
    }

    public class Client
    {
        public AbstractProductA productA;
        public AbstractProductB productB;

        public Client(AbstractFactory factory)
        {
            productA = factory.GetProductA();
            productB = factory.GetProductB();
        }

        public void DoWhatEverWithProductAAndProductB()
        {

        }
    }

    public abstract class AbstractFactory
    {
        public abstract AbstractProductA GetProductA();
        public abstract AbstractProductB GetProductB();
    }

    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA GetProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB GetProductB()
        {
            return new ProductB2();
        }
    }

    public abstract class AbstractProductA
    {

    }

    public class ProductA1 : AbstractProductA
    {

    }

    public class ProductA2 : AbstractProductA
    {

    }

    public abstract class AbstractProductB
    {

    }

    public class ProductB1 : AbstractProductB
    {

    }

    public class ProductB2 : AbstractProductB
    {

    }
}
