using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceTestConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci(7);
            foreach (int f in fibonacci)
            {
                Console.Write(f + " ");
            }//видим на экране1 1 2 3 5 8 13
            Console.WriteLine();



            foreach (int f in fibonacci.GetFirst(3))
            {//видим на экране 1 1 2
                Console.Write(f + " ");
            }
        }
    }
}
