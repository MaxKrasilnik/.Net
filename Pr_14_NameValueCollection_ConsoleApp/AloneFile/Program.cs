using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AloneFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var file2 = new FileStream("Text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var writer = new StreamWriter(file2, Encoding.GetEncoding(1251));

            for (int i = 1; i <= 100; i++)
            {
                writer.Write(i + "\n");
            }

            writer.Close();

            StreamReader reader = File.OpenText("Text.txt");
            string input;

            while ((input = reader.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
            reader.Close();
        }
    }
}
