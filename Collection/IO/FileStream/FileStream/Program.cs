using System;
using System.IO;

namespace FileStreamExample
{
    class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            FileStream fileStream1 = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            FileStream fileStream2 = File.Create(filePath);
            FileStream fileStream3 = File.Open(filePath, FileMode.Create, FileAccess.Write);
            FileStream fileStream4 = File.OpenWrite(filePath);
            FileStream fileStream5 = fileInfo.Create();
            FileStream fileStream6 = fileInfo.Open(FileMode.Create, FileAccess.Write);
            FileStream fileStream7 = fileInfo.OpenWrite();

        }
    }
}
