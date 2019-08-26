using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SortedList;

namespace Pr_SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new System.Collections.SortedList(new DescendingComparer());
            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";
            sort["fouth"] = "4TH";

            foreach(DictionaryEntry i in sort)
            {
                Console.WriteLine("{0}={1}", i.Key, i.Value);
            }
        }
    }
}
