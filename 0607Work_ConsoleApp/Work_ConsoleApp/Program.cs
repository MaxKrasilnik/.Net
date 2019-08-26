using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan", 18);
            Person p1 = new Person("Petr", 16);
            Person p2 = new Person("Sidor", 21);
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p);
            Console.WriteLine();

            Customer c = new Customer(p,"mail@gmail.com", "0662121345", "Kharkov");
            Customer c1 = new Customer(p1, "mail@gmail.com", "0662121345", "Kharkov");
            Customer c2 = new Customer(p2, "mail@gmail.com", "0662121345", "Kharkov");

            Console.WriteLine(c._Person);
            Console.WriteLine(c._Mail);
            Console.WriteLine(c._Phone);
            Console.WriteLine(c._Region);
            Console.WriteLine(c);
            Console.WriteLine();

            MyCustomers cs = new MyCustomers(c);
            cs.Add(c1);
            cs.Add(c2);
            Console.WriteLine(cs);
            Console.WriteLine();
            Console.WriteLine(cs.GetAvaregeAge());
            Console.WriteLine(cs.GetMaxAge());
            Console.WriteLine(cs.GetMinAge());
            Console.WriteLine(cs.GetSumAllAge());

            foreach (Customer item in cs)
            {
                Console.WriteLine(item);
            }

            
            foreach (Customer item in cs.GetCustomers(3))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------");

            cs.SortByAge();

            foreach (Customer item in cs)
            {
                Console.WriteLine(item);
            }

        }
    }
}
