using System;

namespace BinarySearchExample
{
    class Program
    {
        static void Main()
        {
            //create an array
            double[] arr = new double[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //search for 20 in the array (first half)
            int n = Array.BinarySearch(arr, 20);
            Console.WriteLine("20 is found at " + n);

            //search for 100 in the array (second half)
            int n2 = Array.BinarySearch(arr, 70);
            Console.WriteLine("70 is found at " + n2);

            Console.ReadKey();
        }
    }
}
