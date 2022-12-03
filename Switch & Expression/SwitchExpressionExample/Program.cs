namespace SwitchExpressionExample
{
    class Program
    {
        static void Main()
        {
            // 0 - 3
            int animal = 10;
            string result;

            //switch expression
            result = animal switch
            {
                0 => "Cat",
                1 => "Dog",
                2 => "Mouse",
                3 => "Pig",
                _ => "No case available",
            };

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
