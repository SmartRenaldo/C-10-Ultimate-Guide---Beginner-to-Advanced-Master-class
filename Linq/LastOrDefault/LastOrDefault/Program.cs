﻿namespace LINQExample
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", Salary = 7232 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", Salary = 4500 },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "DevOps", Salary = 1293 },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Senior Developer", Salary = 2873 },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Senior Developer", Salary = 6232 },
                new Employee() { EmpID = 106, EmpName = "Jessica", Job = "Senior Developer", Salary = 4545 }
            };

            //Where
            IEnumerable<Employee> a = employees.Where(emp => emp.Job == "Senior Developer");
            Console.WriteLine(a.GetType());
            List<Employee> filteredEmployees = employees.Where(emp => emp.Job == "Senior Developer").ToList();
            Console.WriteLine(filteredEmployees[filteredEmployees.Count - 1].EmpID + ", " + filteredEmployees[filteredEmployees.Count - 1].EmpName + ", " + filteredEmployees[filteredEmployees.Count - 1].Job);

            //Last
            Employee lastEmployee = employees.Last(emp => emp.Job == "Senior Developer");
            Console.WriteLine(lastEmployee.EmpID + ", " + lastEmployee.EmpName + ", " + lastEmployee.Job);

            //LastOrDefault
            Employee lastEmployee2 = employees.LastOrDefault(emp => emp.Job == "Clerk");
            if (lastEmployee2 != null)
            {
                Console.WriteLine(lastEmployee2.EmpID + ", " + lastEmployee2.EmpName + ", " + lastEmployee2.Job);
            }
            else
            {
                Console.WriteLine("No clerk found");
            }

            Console.ReadKey();
        }
    }
}
