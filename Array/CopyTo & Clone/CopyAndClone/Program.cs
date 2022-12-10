using System;

namespace CopyAndClone
{
    //model class
    class Student
    {
        public string Name { get; set; }
        public string Role { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student() { Name = "Simon", Role = "Analyst" },
                new Student() { Name = "Jack", Role = "Designer" },
                new Student() { Name = "Nill", Role = "Artist" }
            };

            //new array
            Student[] highlyPaidEmployees = new Student[5];
            //CopyTo
            students.CopyTo(highlyPaidEmployees, 2);
            students[0].Role = "Changed";

            //print destination array
            Console.WriteLine("CopyTo:");
            foreach (Student emp in highlyPaidEmployees)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.Name + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            //Clone
            Student[] highlyPaidEmployees2 = (Student[])students.Clone();  //createss a  new array & copies from source array to that new array
            Console.WriteLine("\nClone:");
            foreach (Student emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.Name + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.WriteLine("\nClone after changing the source array:");
            students[2].Name = "Elon";
            foreach (Student emp in highlyPaidEmployees2)
            {
                if (!(emp is null))
                {
                    Console.WriteLine(emp.Name + ", " + emp.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.ReadKey();
        }
    }
}
