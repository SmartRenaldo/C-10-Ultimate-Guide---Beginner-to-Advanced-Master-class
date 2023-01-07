namespace ConvertAllExample
{
    class Program
    {
        static void Main()
        {
            //create source collection
            List<int> intCollection = new List<int>() { 1, 8, 2, 7 };

            //read each value into lambda expression; convert the same value into char
            List<char> charCollection = intCollection.ConvertAll(n => Convert.ToChar(n + 65));

            //print the result collection
            foreach (char item in charCollection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
