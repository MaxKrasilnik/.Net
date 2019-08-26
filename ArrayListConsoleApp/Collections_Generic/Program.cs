using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3 };
            int nbr = intList[0];

            var q = new Queue<string>();

            var links = new LinkedList<string>();
            LinkedListNode<string> first = links.AddFirst("1");
            LinkedListNode<string> last = links.AddLast("2");
            LinkedListNode<string> afterLast = links.AddAfter(last, "After last");
            LinkedListNode<string> second = links.AddBefore(last, "second");

            foreach(string s in links)
            {
                Console.WriteLine(s);
            }

        }
    }
}
