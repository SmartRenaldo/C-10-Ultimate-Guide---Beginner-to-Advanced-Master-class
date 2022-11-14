public class Student
{
    public int grade = 5;

    public void PrintGrade()
    {
        System.Console.WriteLine("Grade: " + grade);
    }

    public ref int DoWork()
    {
        //return reference of 'grade' field
        return ref grade;
    }
}

public class Program
{
    static void Main()
    {
        Student s = new Student();
        s.PrintGrade();
        ref int g = ref s.DoWork();
        g = 10;
        s.PrintGrade(); //Output: 10

        System.Console.ReadKey();
    }
}
