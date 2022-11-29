using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace _01_WhatIsEvent
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
