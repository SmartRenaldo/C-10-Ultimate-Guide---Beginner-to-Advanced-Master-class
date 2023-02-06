public record Person(int Id, string Name, int Age);

class Program
{
    static void Main()
    {
        Person person1 = new Person(1, "John", 20);
        Person person2 = new(2, "Scott", 22);
        Console.WriteLine($"{person1.Name}, {person1.Age}");
        Console.WriteLine($"{person2.Name}, {person2.Age}");
        Console.ReadKey();
    }
}
