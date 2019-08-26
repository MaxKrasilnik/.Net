using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceTestConsol
{
    class Fibonacci : IEnumerable, IEnumerator
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
        public Fibonacci(int n)
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
            if (index == fibonachi.Length - 1)
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

        public IEnumerable GetFirst(int n)
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
}
