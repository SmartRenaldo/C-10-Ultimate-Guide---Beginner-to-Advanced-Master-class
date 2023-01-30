namespace StreamWriterReaderExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\europe.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //4 ways to create new object of StreamWriter
            //StreamWriter streamWriter = new StreamWriter(filePath);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //StreamWriter streamWriter = fileInfo.AppendText();
            using (StreamWriter streamWriter = fileInfo.CreateText())
            {
                streamWriter.WriteLine("The pig (Sus domesticus), often called swine, hog, or domestic pig ");
                //some code here
                streamWriter.WriteLine("Cattle (Bos taurus) are large, domesticated, cloven-hooved, herbivores");
                //some code here
                streamWriter.WriteLine("The horse (Equus ferus caballus) is a domesticated, one-toed, hoofed mammal");
                //streamWriter.Close(); //optional
            }

            Console.WriteLine("animal.txt created");
            Console.ReadKey();
        }
    }
}
