using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiApp
{
    public class Fibonachi: IEnumerator, IEnumerable
    {
        int[] fibonachi;
        int index = -1;

        public object Current
        {
            get
            {
                return fibonachi[index];
            }
        }
        public Fibonachi(int n)
        {
            fibonachi = new int[n];
            fibonachi[0] = 1;
            fibonachi[1] = 1;
            for (int i = 2; i < n; i++)
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];


        }
        public IEnumerator GetEnumerator()
        {
            return fibonachi.GetEnumerator();
        }

        public bool MoveNext()
        {
            if(index == fibonachi.Length-1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }
        public void Reset()
        {
            index = -1;
        }

        public IEnumerable GetFirstElements(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == fibonachi.Length)
                    yield break;
                else
                    yield return fibonachi[i];
            }
        }

        public IEnumerable GetPartElements(int n1, int n2)
        {
            for (int i = n1; i < n2; i++)
            {
                if (i == fibonachi.Length)
                    yield break;
                else
                    yield return fibonachi[i];
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fibonachi inst = new Fibonachi(10);
            //Console.WriteLine("Из 5-ти эл-тов");
            //foreach(int f in inst)
            //    Console.WriteLine(f);

            //Console.WriteLine(new string('-', 5));

            //foreach (int f in inst)
            //    Console.WriteLine(f);

            //Console.WriteLine(new string('-', 5));

            //foreach (int f in inst.GetFirstElements(3))
            //    Console.WriteLine(f);

            //Console.WriteLine(new string('-', 5));

            foreach (int f in inst.GetPartElements(2,5))
                Console.WriteLine(f);
        }
    }
}
