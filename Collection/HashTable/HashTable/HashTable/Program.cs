using System.Collections;

namespace HashtableExample
{
    class Program
    {
        static void Main()
        {
            //create a hashtable
            Hashtable employees = new Hashtable()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" },
                { "hello", 10.934 }
            };

            //Add element
            employees.Add(106, "Anna");

            //Remove element
            employees.Remove(103);

            //foreach
            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            //search for specific key
            bool flag = employees.ContainsKey(105);
            Console.WriteLine("\n105 exists: " + flag);

            if (flag)
            {
                Console.WriteLine(employees[105]);
            }

            //search for specific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine("\nScott exists: " + v);

            //Keys
            Console.WriteLine("\nKeys:");
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            //Values
            Console.WriteLine("\nValues:");
            foreach (var item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
