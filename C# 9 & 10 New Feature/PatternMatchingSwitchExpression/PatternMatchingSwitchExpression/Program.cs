class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    public string? Gender { get; set; }
}

class Employee : Person
{
    public double? Salary { get; set; }
}

class Customer : Person
{
    public double? CustomerBalance { get; set; }
}

class Supplier : Person
{
    public double? SupplierBalance { get; set; }
}

class Manager : Employee
{
}

class Descripter
{
    public static string GetDescription(Person person)
    {
        /*switch (person)
        {
            //if the object is of Employee or any of its child type
            case Employee emp when emp.Age >= 13 && emp.Age < 20:
                return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is a Teenager";
            case Employee emp when emp.Age >= 0 && emp.Age < 13:
                return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is Child";
            case Employee emp when emp.Age >= 20 && emp.Age < 60:
                return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is Adult";
            case Employee emp when emp.Age >= 60:
                return $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is a senior citizen";

            //if the object is of Customer or any of its child type
            case Customer cst:
                return $"{person.Name}, {person.Age}, {person.Gender}, {cst.CustomerBalance}";

            //if the object is of Supplier or any of its child type
            case Supplier sup:
                return $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}";

            default:
                return $"{person.Name}, {person.Age}, {person.Gender}";
        }*/
        return person switch
        {
            Employee emp when emp.Age >= 13 && emp.Age < 20 => 
                $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is a Teenager",
            Employee emp when emp.Age >= 0 && emp.Age < 13 =>
                $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is Child",
            Employee emp when emp.Age >= 20 && emp.Age < 60 =>
                $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is Adult",
            Employee emp when emp.Age >= 60 =>
                $"{person.Name}, {person.Age}, {person.Gender}, {emp.Salary}\n{person.Name} is a senior citizen",
            Customer cst => $"{person.Name}, {person.Age}, {person.Gender}, {cst.CustomerBalance}",
            Supplier sup => $"{person.Name}, {person.Age}, {person.Gender}, {sup.SupplierBalance}",
            _ => $"{person.Name}, {person.Age}, {person.Gender}"
        };
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager() { Name = "John", Gender = "Male", Age = 20, Salary = 3000 };
        Customer customer = new Customer() { Name = "Smith", Gender = "Male", Age = 30, CustomerBalance = 1000 };
        Console.WriteLine(Descripter.GetDescription(manager));
        Console.ReadKey();
    }
}

