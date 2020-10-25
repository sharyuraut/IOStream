using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace FileIODemo
{
    class FileWriteOperations
    {
        public void writeusingStreamWriter()
        {
            string path = @"C:\Users\HP LAPTOP\source\repos\FileIODemo\FileIODemo\sample.txt";

            using(StreamWriter source = File.AppendText(path))
            {
                source.WriteLine("hey!!");
                source.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }

        public void ReaderUsingStreamer()
        {
            string path = @"C:\Users\lenovo\Desktop\BridgeLabz\SystemIODemo\SystemIODemo\sample.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) is null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}
