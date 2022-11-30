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
        //step 1: create event
        public event MyDelegateType myEvent;

        //step 2: raise event
        public void RaiseEvent(int a, int b)
        {
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }
        }
    }
}
