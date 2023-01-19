namespace CovarianceExample
{
    class Animal
    {
        public int LegNumber { get; set; }
    }

    class Parrot : Animal
    {
    }

    class Cat : Animal
    {
    }

    interface IMover<out T>
    {
        T Move();
    }
    class Mover<T> : IMover<T>
    {
        public T thing { get; set; }
        public T Move()
        {
            return thing;
        }
    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            //create object
            Animal livingThing = new Parrot(); //not covariance
            Parrot parraot = new Parrot() { LegNumber = 2 }; //normal

            // Covariance = supply the child type name, where the parent type name is expected.
            IMover<Animal> mover = new Mover<Parrot>() { thing = parraot };
            Console.WriteLine("Moving with " + mover.Move().LegNumber + " legs"); //"LivingThing" vs "Parrot"; supplying the child type (Parrot), where the parent type (LivingThing) is expected


            //Covariance in real life
            Sample s = new Sample();
            s.PrintValues(new List<string>() { "hello", "world" });

            Console.ReadKey();
        }
    }
}
