using System;
using ClassLibrary1;

namespace ArrayOfObjectsExample
{
    class Program
    {
        static void Main()
        {
            //create array of objects
            Employee[ ] employees = new Employee[ ]
            {
                new Employee() { EmpID = 1, EmpName = "Tom" },
                new Employee() { EmpID = 2, EmpName = "Tim" },
                new Employee() { EmpID = 3, EmpName = "Tony" }
            };

            //foreach loop for array of objects
            foreach(Employee item in employees)
            {
                if (item.EmpID >= 102)
                {
                    Console.WriteLine(item.EmpID + ", " + item.EmpName);
                }
            }

            Console.ReadKey();
        }
    }
}
