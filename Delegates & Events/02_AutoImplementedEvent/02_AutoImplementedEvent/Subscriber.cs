using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace _02_AutoImplementedEvent
{
    public class Subscriber
    {
        //target method
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
