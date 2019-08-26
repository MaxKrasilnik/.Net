using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var directory = new DirectoryInfo(@"D:\TEXTDIR");

            if(directory.Exists)
            {
                Console.WriteLine("Full name: " + directory.FullName);
                Console.WriteLine("Name: " + directory.Name);
                Console.WriteLine("Parent: " + directory.Parent);
                Console.WriteLine("CreationTime: " + directory.CreationTime);
                Console.WriteLine("Attributes: " + directory.Attributes);
                Console.WriteLine("Root: " + directory.Root);
                Console.WriteLine("Attributes: " + directory.Attributes);
                Console.WriteLine("Attributes: " + directory.Attributes);

                FileInfo[] files = directory.GetFiles("*.txt");
                Console.WriteLine($"Найдено {files.Length} *.txt файлов");

                foreach(FileInfo file in files)
                {
                    Console.WriteLine("File name" + file.Name);


                }

                //directory.CreateSubdirectory("SUBDIR");

                //directory.CreateSubdirectory(@"MyDir\SubDir");
                                 //MyDir\SubDir
                Directory.Delete(@"D:\MyDir\SubDir", true);
            }
            else
            {
                Console.WriteLine("Нет директории", directory.FullName);
            }
        }
    }
}
