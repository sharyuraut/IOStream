using System;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoesFileExists();
            //ReadLines();

            FileWriteOperations readwritethroughStreamReader = new FileWriteOperations();
            readwritethroughStreamReader.writeusingStreamWriter();
            //readwritethroughStreamReader.ReadFromStream();
        }
        public static void DoesFileExists()
        {
            String path = @"C:\Users\HP LAPTOP\source\repos\FileIODemo\FileIODemo\sample.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

        }
        public static void ReadLines()
        {
            String path = @"C:\Users\HP LAPTOP\source\repos\FileIODemo\FileIODemo\sample.txt"; ;

            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadLine();

        }
    }
}
