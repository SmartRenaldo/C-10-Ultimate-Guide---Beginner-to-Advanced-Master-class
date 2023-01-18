using System;
using System.Collections.Generic;

namespace IComparerExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
    }

    public enum SortBy
    {
        EmpID, EmpName, Job
    }

    class EmployeeComparer : IComparer<Employee>
    {
        public EmployeeComparer(SortBy sortBy = SortBy.EmpID)
        {
            this.sortBy = sortBy;
        }

        //Sort by selected column
        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            switch (this.sortBy)
            {
                case SortBy.EmpID:
                    result = x.EmpID - y.EmpID; break;
                case SortBy.EmpName:
                    result = (x.EmpName != null) ? x.EmpName.CompareTo(y.EmpName) : 0; break;
                case SortBy.Job:
                    result = (x.Job != null) ? x.Job.CompareTo(y.Job) : 0; break;
                default:
                    result = 0; break;
            }
            return result;
        }

        public SortBy sortBy { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 104, EmpName = "Mary", Job = "Designer"},
                new Employee() { EmpID = 102, EmpName = "Trump", Job = "Manager"},
                new Employee() { EmpID = 101, EmpName = "Steven", Job = "Consultant"},
                new Employee() { EmpID = 103, EmpName = "Morrison", Job = "Manager"},
                new Employee() { EmpID = 105, EmpName = "Sara", Job = null}
            };

            EmployeeComparer customComparer = new EmployeeComparer();
            employees.Sort(customComparer);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.EmpID + ", " + emp.EmpName + ", " + emp.Job);
            }
            Console.ReadKey();
        }
    }
}
