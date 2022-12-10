using System;

namespace DeepCopyExample
{
    //model class
    class Student: ICloneable
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public object Clone()
        {
            Student new_one = new Student() { Name = this.Name, Role = this.Role };
            return new_one;
        }
    }
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student() { Name = "Smith", Role = "Developer" },
                new Student() { Name = "Jack", Role = "Singer" },
                new Student() { Name = "Adelaide", Role = "Seller" }
            };

            //deep copy
            Student[] students_deep_copy = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                var result = (Student) students[i].Clone();
                students_deep_copy[i] = result;
            }

            Console.WriteLine("Deep copy:");
            foreach (Student emp in students_deep_copy)
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

            //new array
            Student[] highlyPaidStudents = new Student[5];
            //CopyTo
            students.CopyTo(highlyPaidStudents, 2);
            students[0].Role = "Changed";

            //print destination array
            Console.WriteLine("\nCopyTo:");
            foreach (Student emp in highlyPaidStudents)
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
            Student[] highlyPaidStudents2 = (Student[]) students.Clone();  //createss a  new array & copies from source array to that new array
            Console.WriteLine("\nClone:");
            foreach (Student std in highlyPaidStudents2)
            {
                if (!(std is null))
                {
                    Console.WriteLine(std.Name + ", " + std.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            Console.WriteLine("\nDeep copy after changing:");
            foreach (Student std in students_deep_copy)
            {
                if (!(std is null))
                {
                    Console.WriteLine(std.Name + ", " + std.Role);
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
