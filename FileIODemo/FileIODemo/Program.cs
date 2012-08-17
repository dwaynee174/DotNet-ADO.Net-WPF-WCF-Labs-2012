using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ////create a FileStream

            //FileStream fs = new FileStream ("C:\\msnet\\testfile.txt",FileMode.OpenOrCreate,FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //Console.WriteLine("Type data to write in the file and press enter to terminate");
            //sw.Write(Console.ReadLine());

            ////inorder to flush the data from the buffer and save it in the file
            //sw.Flush();
            //Console.WriteLine("file created successfully");
            //Console.ReadLine();
            FileStream fs = new FileStream("C:\\msnet\\testfile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Contents of the file are: ");
            Console.WriteLine(sr.ReadToEnd());
            fs.Close();

            Console.ReadLine();
        }
    }
}
