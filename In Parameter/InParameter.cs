public class InParameter
{
    static void Main(string[] args)
    {
        int readonlyArgument = 55;
        InArgExample(readonlyArgument);
        Console.WriteLine(readonlyArgument);     // value is still 55
    }

    void InArgExample(in int number)
    {
        // Uncomment the following line to see error
        //number = 19;
    }
}
