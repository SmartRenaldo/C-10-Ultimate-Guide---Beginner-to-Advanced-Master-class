using System;

namespace ResizeExample
{
    class Program
    {
        static void Main()
        {
            //create array
            int[] a = new int[] { 10, 20, 30 };

            //resize array to 2
            Array.Resize(ref a, 2);

            //print array
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //create array
            int[] b = new int[] { 10, 20, 30 };

            //resize array to 5
            Array.Resize(ref b, 5);

            //print array
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
