using System;

namespace ReverseExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] a = new int[] { 46, 94, 35, 24, 6, 69 };

            //sort ascending order
            Array.Sort(a);

            //display array after sort
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //reverse the array (it becomes descending order)
            Array.Reverse(a);

            //display array after reverse
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
