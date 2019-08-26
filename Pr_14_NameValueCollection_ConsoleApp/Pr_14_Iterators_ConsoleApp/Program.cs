using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pr_14_Iterators_ConsoleApp
{
    public class Letter
    {
        char ch = 'А';
        int end;

        public Letter(int end)
        {
            this.end = end;
        }

        public IEnumerator GetEnumenator()
        {
            /* for (int i = 0; i < this.end; i++)
            {
                if (i == 33) yield break;
                yield return (char)(ch + i);
            } */

            yield return 'A';
            yield return '1';
            yield return '2';
        }

        public IEnumerable MyItr(int begin, int end)
        {
            for (int i = begin; i <= end; i++)
                yield return (char)(ch + i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько букв вывести? ");
            int i = int.Parse(Console.ReadLine());

            Letter lt = new Letter(i);

            /* foreach (char c in lt)
                Console.Write(c + " "); */

            foreach (char c in lt.MyItr(5, 25))
                Console.Write(c + " ");
            Console.WriteLine();
        }
    }
}