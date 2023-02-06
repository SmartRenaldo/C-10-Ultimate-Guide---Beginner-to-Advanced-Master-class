public record Person(int Id, string Name, int Age);
public record Student(Person Person, string School);

class Program
{
    static void Main()
    {
        Student student = new Student(new Person(1, "John", 20), "University of Adelaide");
        var ((_, name, age), school) = student;
        Console.WriteLine($"{name}, {age}, {school}");
        Console.ReadKey();
    }
}
