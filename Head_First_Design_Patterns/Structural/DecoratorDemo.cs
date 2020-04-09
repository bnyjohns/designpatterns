using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns
{
    class DecoratorDemo
    {
        static void Main()
        {
            Coffee coffee = new SimpleCoffee();

            coffee = new MilkDecorator(coffee);
            Console.WriteLine(coffee.GetIndegredients());

            coffee = new SugarDecorator(coffee);
            Console.WriteLine(coffee.GetIndegredients());
        }
    }

    public abstract class Coffee
    {
        public abstract string GetIndegredients();
        public abstract int GetCost();
    }

    public class SimpleCoffee : Coffee
    {
        public override int GetCost()
        {
            return 1;
        }

        public override string GetIndegredients()
        {
            return "Coffee";
        }
    }

    public class MilkDecorator : Coffee
    {
        Coffee _coffee;
        public MilkDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }
        public override int GetCost()
        {
            return _coffee.GetCost() + 2;
        }

        public override string GetIndegredients()
        {
            return _coffee.GetIndegredients() + ", Milk";
        }
    }

    public class SugarDecorator: Coffee
    {
        Coffee _coffee;
        public SugarDecorator(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override int GetCost()
        {
            return _coffee.GetCost() + 3;
        }

        public override string GetIndegredients()
        {
            return _coffee.GetIndegredients() + ", Sugar";
        }
    }
}
