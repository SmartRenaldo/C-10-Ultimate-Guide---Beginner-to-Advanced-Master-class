namespace HashSetExample3
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("IntersectWith");
                //create two HashSet's
                HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };
                HashSet<string> employees2022 = new HashSet<string>() { "John", "Scott", "Amar", "Akhil", "Smith", "David" };

                //IntersectWith
                employees2021.IntersectWith(employees2022);
                foreach (string item in employees2021)
                {
                    Console.WriteLine(item);
                }
            }

            {
                Console.WriteLine("UnionWith");

                HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen" };
                HashSet<string> employees2022 = new HashSet<string>() { "John", "Scott", "Amar", "Akhil", "Smith", "David" };

                //Union
                employees2021.UnionWith(employees2022);
                foreach (string item in employees2021)
                {
                    Console.WriteLine(item);
                }
            }

            //create an object of HashSet
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            //Add
            messages.Add("Good Luck");

            //Remove
            messages.Remove("Have a good day");

            //Remove
            messages.RemoveWhere(m => m.EndsWith("You"));

            //Search
            Console.WriteLine("Contains Good Morning: " + messages.Contains("Good Morning"));

            //Count
            Console.WriteLine("Count: " + messages.Count);

            //foreach
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }


            Console.ReadKey();
        }
    }
}
