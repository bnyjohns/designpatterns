using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.TemplateDemo
{
    public class TemplateDemo
    {
        //static void Main()
        //{
        //    Beverage tea = new Tea();
        //    tea.PrepareBeverage();

        //    Beverage coffee = new Coffee();
        //    coffee.PrepareBeverage();
        //}
    }

    public abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected void BoilWater()
        {

        }

        protected abstract void Brew();
        protected void PourInCup()
        {

        }
        protected abstract void AddCondiments();


    }

    public class Tea : Beverage
    {
        protected override void AddCondiments()
        {
            throw new NotImplementedException();
        }

        protected override void Brew()
        {
            throw new NotImplementedException();
        }
    }

    public class Coffee : Beverage
    {
        protected override void AddCondiments()
        {
            throw new NotImplementedException();
        }

        protected override void Brew()
        {
            throw new NotImplementedException();
        }
    }
}
