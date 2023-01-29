namespace DirectoryExample
{
    class Program
    {
        static void Main()
        {
            //CreateDirectory
            string countriesFolderPath = @"c:\mock\countries";
            Directory.CreateDirectory(countriesFolderPath);
            Console.WriteLine("countries folder created");

            string indiaPath = countriesFolderPath + @"\Russia";
            string ukPath = countriesFolderPath + @"\Ukraine";
            string usaPath = countriesFolderPath + @"\USA";
            Directory.CreateDirectory(indiaPath);
            Directory.CreateDirectory(ukPath);
            Directory.CreateDirectory(usaPath);
            Console.WriteLine("Sub directories 'Russia', 'Ukraine' and 'USA' created");

            string capitalsFilePath = countriesFolderPath + @"\capitals.txt";
            string sportsFilePath = countriesFolderPath + @"\sports.txt";
            string populationFilePath = countriesFolderPath + @"\population.dat";

            //File.Create
            File.Create(capitalsFilePath).Close();
            File.Create(sportsFilePath).Close();
            File.Create(populationFilePath).Close();
            Console.WriteLine("Files 'capitals.txt', 'sports.txt', 'population.dat' created");

            //Move
            string worldFolderPath = @"c:\mock\world";
            Directory.Move(countriesFolderPath, worldFolderPath);
            Console.WriteLine("'countries' folder moved to 'world'");

            //GetFiles
            string[] files = Directory.GetFiles(worldFolderPath, "*.txt");
            Console.WriteLine("\nFiles:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            //GetDirectories
            string[] directories = Directory.GetDirectories(worldFolderPath);
            Console.WriteLine("\nSub directories:");
            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }

            //Delete
            Directory.Delete(worldFolderPath, true);
            Console.WriteLine("'world' folder deleted");
            Console.ReadKey();
        }
    }
}
