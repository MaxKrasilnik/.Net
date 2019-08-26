using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_14_FibonacciSequence_ConsoleApp
{
    public class FibonacciSequence : IEnumerator, IEnumerable
    {
        int[] fibonacci;
        int index = -1;
        
        public FibonacciSequence(int n)
        {
            fibonacci = new int[n];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2; i < n; i++)
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        public object Current
        {
            get { return fibonacci[index]; }
        }

        public IEnumerator GetEnumerator()
        {
            return fibonacci.GetEnumerator();
        }

        public bool MoveNext()
        {
            if (index == fibonacci.Length - 1)
            {
                //Reset();
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
                if (i == fibonacci.Length)
                    yield break;
                else
                    yield return fibonacci[i];
            }
        }

        public IEnumerable GetPathElements(int begin, int end)
        {
            for (int i = begin; i < end; i++)
            {
                if (i == fibonacci.Length)
                    yield break;
                else
                    yield return fibonacci[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence f1 = new FibonacciSequence(10);

            Console.WriteLine("Fibonacci 10 elements: ");

            foreach (int f in f1)
                Console.WriteLine(f);

            Console.WriteLine(new string('-', 5));

            foreach (int f in f1)
                Console.WriteLine(f);

            Console.WriteLine(new string('-', 5));

            foreach (int f in f1.GetFirstElements(3))
                Console.WriteLine(f);

            Console.WriteLine(new string('-', 5));

            foreach (int f in f1.GetPathElements(5, 10))
                Console.WriteLine(f);
        }
    }
}