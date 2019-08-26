using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = File.Open(@"D:\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //StreamReader reader = new StreamReader(file);
            //Console.Write(reader.ReadToEnd());

            //reader.Close();

            /////

            //reader = File.OpenText(@"D:\test.txt");
            //Console.Write(reader.ReadToEnd());
            //reader.Close();

            /////

            //Console.Write(File.ReadAllText(@"D:\test.txt"));

            //StreamReader reader1 = File.OpenText(@"D:\test.txt");

            //while(!reader1.EndOfStream)
            //{
            //    string line = reader1.ReadLine();
            //    if(line != null && line.Contains("Hello"))
            //    {
            //        Console.WriteLine("Found:");
            //        Console.WriteLine(line);
            //        break;
            //    }
            //}


            /////

            //var writer = new StreamWriter(file);
            //writer.WriteLine("Hello");
            //writer.Close();

            /////

            //writer = File.CreateText(@"D:\test.txt");
            //writer.WriteLine("Hello");
            //writer.Close();

            /////

            //File.WriteAllText(@"D:\test.txt", "Hello");

            /////

            //file = null;
            //file = File.Open(@"D:\test.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
            //file.Close();
            /////

            //file = File.OpenWrite(@"D:\test.txt");
            //file.Close();

            var file = File.Create(@"D:\test2.txt");
            var bwriter = new BinaryWriter(file);

            long number = 100;

            var bytes = new byte[] { 10, 20, 50, 100 };
            string s= "hunger";

            bwriter.Write(number);
            bwriter.Write(bytes);
            bwriter.Write(s);

            bwriter.Close();

            FileStream fs = File.Open(@"D:\test2.txt", FileMode.Open);

            var breader = new BinaryReader(fs);

            long number_ = breader.ReadInt64();
            byte[] bytes_ = breader.ReadBytes(4);
            string s_ = breader.ReadString();

            Console.WriteLine(number_);
            foreach(byte b in bytes_)
            {
                Console.Write("[{0}]", b);
            }

            Console.WriteLine();
            Console.WriteLine(s_);





        }
    }
}
