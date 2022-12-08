using System;

namespace JaggedArraysExample
{
    class Program
    {
        static void Main()
        {
            //create jagged array
            int[][] a = new int[5][];
            a[0] = new int[3] { 10, 20, 30 };
            a[1] = new int[4] { 40, 50, 60, 70 };
            a[2] = new int[2] { 80，90 };
            a[3] = new int[9] { 100，110, 120, 130, 140，150, 160, 170, 180 };
            a[4] = new int[4] { 190, 200, 210, 220 };

            //read jagged array
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
