using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.AdapterDemo
{
    public class AdapterDemo
    {
        //static void Main()
        //{
        //    ITurkey turkey = new Turkey();
        //    IDuck duck = new Duck(); //normal
        //    //now we will adapt a turkey to a duck
        //    IDuck adaptedTurkey = new TurkeyAdapter(turkey);
        //    adaptedTurkey.Quack();
        //    adaptedTurkey.Run();
        //}
    }

    //Adapter to adapt Turkey to a Duck
    public class TurkeyAdapter : IDuck
    {
        ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Quack()
        {
            _turkey.Cry();
        }

        public void Run()
        {
            for (int i = 0; i < 3; i++)
                _turkey.SmallRun();
        }
    }

    public interface IDuck
    {
        void Quack();
        void Run();
    }

    public interface ITurkey
    {
        void Cry();
        void SmallRun();
    }

    public class Duck : IDuck
    {
        public void Quack()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Turkey : ITurkey
    {
        public void Cry()
        {
            throw new NotImplementedException();
        }

        public void SmallRun()
        {
            throw new NotImplementedException();
        }
    }


}
