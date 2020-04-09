using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.FactoryDemo
{
    class FactoryDemo
    {
        //static void Main(string[] args)
        //{
        //    PizzaStore store = new ChennaiPizzaStore();
        //    store.OrderPizza("");
            
        //}
    }

    public abstract class PizzaStore
    {        
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            return pizza;
        }
        protected abstract Pizza CreatePizza(string pizzaType); //Factory method
    }

    public class ChennaiPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            PizzaIndegredientFactory pizzaIndegredientFactory = new ChennaiPizzaIndegredientFactory();
            Pizza pizza = new CheesePizza(pizzaIndegredientFactory);
            return pizza;
        }
    }

    public abstract class Pizza
    {
        public abstract Pizza PreparePizza();

        public void BakePizza()
        {

        }

        public void CutPizza()
        {

        }
    }

    public class CheesePizza : Pizza
    {
        PizzaIndegredientFactory indegredientFactory; //Abstract Factory
        public CheesePizza(PizzaIndegredientFactory pizzaIndegredientFactory)
        {
            indegredientFactory = pizzaIndegredientFactory;
        }

        public override Pizza PreparePizza()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class PizzaIndegredientFactory
    {

    }

    public class ChennaiPizzaIndegredientFactory : PizzaIndegredientFactory
    {

    }
}
