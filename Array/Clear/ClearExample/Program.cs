using System;

namespace ClearExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] a = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            //clear elements of array
            Array.Clear(a, 3, 3);

            //display array
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //create array
            int[] b = new int[] { 10, 20, 30, 40, 50, 60, 70 };

            //clear elements of array
            Array.Clear(b, 0, b.Length);

            //display array
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
