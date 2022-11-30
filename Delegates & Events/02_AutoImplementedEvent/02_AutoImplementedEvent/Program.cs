using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace _02_AutoImplementedEvent
{
    public class Program
    {
        static void Main()
        {
            //create object of subscriber class
            Subscriber subscriber = new Subscriber();

            //create object of publisher class
            Publisher publisher = new Publisher();

            //handle the event (or) subscribe to event
            publisher.myEvent += subscriber.Add;

            //invoke the event
            publisher.RaiseEvent(10, 30);

            Console.ReadKey();
        }
    }
}
