using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_First_Design_Patterns.ObserverDemo
{
    public class ObserverDemo
    {
        //static void Main()
        //{
        //    Publisher publisher = new Publisher();
        //    publisher.MyEvent += new Subscriber().DoSth;
        //    publisher.TriggerSubscriber();
        //}
        
    }

    public class DoStuff
    {
        public delegate void DoStuffDelegate(object sender, EventArgs e);        
    }

    public class Publisher
    {
        public event DoStuff.DoStuffDelegate MyEvent;
        public EventHandler<EventArgs> eventHandler;
        public void TriggerSubscriber()
        {
            if (MyEvent != null)
                MyEvent.Invoke(new object(), new EventArgs());

            if (eventHandler != null)
                eventHandler.Invoke(new object(), new EventArgs());
        }
    }

    public class Subscriber
    {
        public void DoSth(object sender, EventArgs e)
        {

        }
    }
    
}
