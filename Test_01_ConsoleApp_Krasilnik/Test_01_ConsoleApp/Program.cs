using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AutoShop> list = new List<AutoShop>();
            list.Add(new AutoShop("b", 20, 30, 40, "50"));
            list.Add(new AutoShop("a", 10, 20, 30, "40"));
            list.Add(new AutoShop("d", 40, 50, 60, "70"));
            list.Add(new AutoShop("c", 30, 40, 50, "60"));
            list.Add(new AutoShop("e", 50, 60, 70, "80"));

            for(int i=0; i < list.Count; i++)
            {
                list[i].Print();
            }
            Console.WriteLine("-------------------------------------");
            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Print();
            }
        }
    }
}
