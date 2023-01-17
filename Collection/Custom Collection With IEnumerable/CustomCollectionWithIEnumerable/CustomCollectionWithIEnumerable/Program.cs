using System;
using System.Collections.Generic;
using System.Collections;

namespace CustomCollectionsWithIEnumerable
{
    public enum TypeOfStudent
    {
        RegularStudent, GoodStudent
    }

    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public TypeOfStudent StudentType { get; set; }
    }

    //custom collection class
    public class StudentList : IEnumerable<Student>
    {
        //private collection as a field
        private List<Student> students = new List<Student>();

        IEnumerator Enumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Count; i++)
            {
                yield return students[i];
            }
        }

        //Add with validations
        public void Add(Student cust)
        {
            if (cust.StudentID.StartsWith("A") || cust.StudentID.StartsWith("a"))
            {
                students.Add(cust);
            }
            else
            {
                Console.WriteLine("Invalid Student ID");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            StudentList customersList = new StudentList() {
                new Student() { StudentID = "A101", StudentName = "James", Email = "james@example.com", StudentType = TypeOfStudent.RegularStudent },
                new Student() { StudentID = "A201", StudentName = "Bob", Email = "bob@example.com", StudentType = TypeOfStudent.GoodStudent },
                new Student() { StudentID = "A301", StudentName = "Alice", Email = "alice@example.com", StudentType = TypeOfStudent.GoodStudent }
            }; //3 customers

            //Add
            Student new_cust = new Student() { StudentID = "A456", StudentName = "Jacob", Email = "jacob@example.com", StudentType = TypeOfStudent.GoodStudent };
            customersList.Add(new_cust);

            foreach (Student customer in customersList)
            {
                Console.WriteLine(customer.StudentID + ", " + customer.StudentName + ", " + customer.Email + ", " + customer.StudentType);
            }
            Console.ReadKey();
        }
    }
}
