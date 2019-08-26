using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryClass_Pr_06;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Address add1 = new Address("61044", "Kharkov","Kobchino","abc");
            //Employee inst1 = new Employee();


            //System.Console.WriteLine("PostIndex", inst.PostIndex);
            //System.Console.WriteLine(inst.PostIndex);

            System.Console.WriteLine(add1.ToString());

            Address2 add2 = new Address2("61044", "Kharkov", "Kobchino", "abc", "42");

            System.Console.WriteLine(add2.ToString());

            Console.WriteLine("add1==add2 " + (add1 == add2));

            Console.WriteLine("add1==add2 Equals " + (add1.Equals(add2)));
        }
    }
}
