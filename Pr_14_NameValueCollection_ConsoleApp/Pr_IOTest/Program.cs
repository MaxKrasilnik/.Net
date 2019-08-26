using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr_IOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new FileInfo(@"C:\Windows\notepad.exe");

            try
            {
                file.CopyTo(@"D:\aaaa.exe");
                Console.WriteLine("Seccess copied");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(DriveInfo d in drives)
            {
                Console.WriteLine("Drive: {0} Type: {1}", d.Name, d.DriveType);
            }



            string path = @"C:\Windows\notepad.exe";
            Console.WriteLine("Ext: {0}", Path.GetExtension(path));

            Console.WriteLine("Change Path: {0}", path = Path.ChangeExtension(path, "bak"));
            Console.WriteLine(path);





        }
    }
}
