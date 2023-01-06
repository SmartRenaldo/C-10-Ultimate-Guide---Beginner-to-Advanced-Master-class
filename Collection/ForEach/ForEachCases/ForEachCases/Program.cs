namespace ToArrayForEachExample
{
    class Program
    {
        static void Main()
        {
            //create list
            List<string> myFriends = new List<string>() { "Scott", "Allen", "James", "Jones" };

            //ForEach method
            Console.WriteLine("\nForEach method:");
            myFriends.ForEach(f => { Console.WriteLine(f); });
            Console.ReadKey();
        }
    }
}
