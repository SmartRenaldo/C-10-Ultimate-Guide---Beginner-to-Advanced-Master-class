using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //delegate type
    public delegate void MyDelegateType(int num1, int num2);

    //publisher
    public class Publisher
    {
        private MyDelegateType myDelegateType;

        //step 1: create event
        public event MyDelegateType myEvent
        {
            add
            {
                myDelegateType += value;
            }
            remove
            { 
                myDelegateType -= value;
            }
        }

        //step 2: raise event
        public void RaiseEvent(int a, int b)
        {
            this.myDelegateType(a, b);
        }
    }
}
