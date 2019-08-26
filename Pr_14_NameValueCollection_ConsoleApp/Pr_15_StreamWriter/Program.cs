using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Библиотека для работы с файлами

namespace Pr_15_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var file = new FileInfo("Text.txt");

            //StreamWriter writer = file.CreateText();

            var file2 = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(file2, Encoding.GetEncoding(1251));

            writer.WriteLine("first string of the text...");
            writer.WriteLine("second string of the text...");
            writer.Write(writer.NewLine);
            writer.WriteLine("third string of the text...");

            for(int i=0; i < 10; i++)
            {
                writer.Write(i + " ");
            }

            writer.Write(writer.NewLine);

            writer.Close();

            Console.WriteLine("File Text.txt create");


            StreamReader reader = File.OpenText("Text.txt");
            string input;

            while((input = reader.ReadLine())!= null)
            {
                Console.WriteLine(input);
            }
            reader.Close();


        }
    }
}
