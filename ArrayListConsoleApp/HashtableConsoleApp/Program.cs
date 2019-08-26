using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableConsoleApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var emailLookup = new Hashtable();
            emailLookup.Add("a@a.ua", "Иванов Иван");
                      //ключ уникален 
            emailLookup["a@a.ua"] = "Петров Петр";
                                   //его значение может повторятся
            emailLookup["a1@a.ua"] = "Сидоров Петр";

            Console.WriteLine(emailLookup["a@a.ua"]);
            Console.WriteLine(emailLookup["a1@a.ua"]);
            Console.WriteLine(emailLookup.Count);

            foreach(object n in emailLookup)
            {
                Console.WriteLine(n);
            }

            foreach (DictionaryEntry n in emailLookup)
            {
                Console.WriteLine(n.Key+ "  "+n.Value);
            }

            M1();

            M2();
        }

        public static void M1()
        {
            var h = new Hashtable();
            var key1 = new Pearson("Petrov");
            var key2 = new Pearson("Petrov");

            Console.WriteLine(key1.GetHashCode());
            Console.WriteLine(key2.GetHashCode());

            h[key1] = "dep1";
            h[key1] = "dep2";
        }

        public static void M2()
        {
            var dehash = new Hashtable(new InsensitiveComparer());
            dehash["First"] = "1st";
            dehash["Second"] = "2nd";
            dehash["Third"] = "3rd";
            dehash["Fourth"] = "4th";
            dehash["fouth"] = "4TH";
        }
    }
}
