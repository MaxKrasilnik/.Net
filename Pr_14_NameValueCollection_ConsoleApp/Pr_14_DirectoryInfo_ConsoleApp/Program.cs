using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr_14_DirectoryInfo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var directory = new DirectoryInfo(@"D:\directoryInfo");

            //if (directory.Exists)
            //{
            //    Console.WriteLine("Fullname: {0}", directory.FullName);
            //    Console.WriteLine("Name: {0}", directory.Name);
            //    Console.WriteLine("Parent: {0}", directory.Parent);
            //    Console.WriteLine("CreationTime: {0}", directory.CreationTime);
            //    Console.WriteLine("Attributes: {0}", directory.Attributes.ToString());
            //    Console.WriteLine("Root: {0}", directory.Root);
            //    Console.WriteLine("LastAccessTime: {0}", directory.LastAccessTime);
            //    Console.WriteLine("LastWriteTime: {0}", directory.LastWriteTime);

            //    FileInfo[] files = directory.GetFiles("*.txt");
            //    Console.WriteLine("Найдено {0} *.txt файлов", files.Length);

            //    directory.CreateSubdirectory("SUBDIR");
            //    directory.CreateSubdirectory(@"MyDir/SubMyDir");

            //    Directory.Delete(@"D:\TESTDIR\MyDir", true);


            //string[] drives = Directory.GetLogicalDrives();
            //Console.WriteLine("Имеющиеся диски:");

            //foreach (string drive in drives)
            //    Console.WriteLine("- {0}", drive);
            //}
            //else
            //    Console.WriteLine("Директория с именем: {0} не существует.", directory.FullName);


            ////////////////////////////////////////////////////////////////////////

            //var file = new FileInfo(@"D:\Test.txt");

            ////FileStream stream = file.Create();
            //FileStream stream = file.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            //Console.WriteLine("FullName {0}", file.FullName);

            //stream.Close();

            //file.Delete();

            /////////////////////////////////////////////////////////////

            //using (FileStream s = file.Create())
            //{
            //    ;///
            //}

            //////////////////////////////////////////////////////

            //var stream = new FileStream("Test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);


            //for(int i=0; i < 256; i++)
            //{
            //    stream.WriteByte((byte)i);
            //}

            //Console.WriteLine(stream.Position);

            //stream.Position = 0;

            //for (int i = 0; i < 256; i++)
            //{
            //    stream.WriteByte((byte)i);
            //}

            /////////////////////////////////////////////////////

            var memory = new MemoryStream();

            memory.Capacity = 256;

            for (int i = 0; i < 256; i++)
            {
                memory.WriteByte((byte)i);
            }

            memory.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + memory.ReadByte());
            }

            var f1 = new FileStream("Dump.dat", FileMode.Create, FileAccess.ReadWrite);

            memory.WriteTo(f1);

            f1.Position = 0;

            for (int i = 0; i < 256; i++)
            {
                Console.Write(" " + f1.ReadByte());
            }

            memory.Close();
            f1.Close();


        }
    }
}