namespace IteratorExample
{
    public class Sample
    {
        public List<double> Prices { get; set; } = new List<double>() { 70, 34, 18, 80 };

        //Iterator method
        public IEnumerable<double> Method()
        {
            double sum = 0;
            foreach (double price in Prices)
            {
                sum += price;
                yield return sum;  //70, 104, 122, 202
            }
        }

        public IEnumerable<int> Method2()
        {
            Console.WriteLine("Execute the first line of Method2");
            yield return 1;
            Console.WriteLine("Execute the second line of Method2");
            yield return 2;
        }
    }
    class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            var prices_enumerable = s.Method();
            var prices_enumerator = prices_enumerable.GetEnumerator();
            prices_enumerator.MoveNext();
            Console.WriteLine("Total price up to first product: " + prices_enumerator.Current); //70
            Console.WriteLine("Some more code....");
            prices_enumerator.MoveNext();
            Console.WriteLine("Total price up to second product: " + prices_enumerator.Current); //104
            Console.WriteLine("Some more code....");

            Console.WriteLine();
            var prices_enumerable2 = s.Method2();
            var prices_enumerator2 = prices_enumerable2.GetEnumerator();
            while (prices_enumerator2.MoveNext())
            {
                Console.WriteLine(prices_enumerator2.Current);
            }

            Console.WriteLine();
            var prices_list2 = prices_enumerable2.ToList();
            foreach (var price in prices_list2)
            {
                Console.WriteLine(price);
            }

            Console.ReadKey();
        }
    }
}
