using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursiaLiambdaConsoleApplication1
{
    delegate void MyD(int argument);
    class Program
    {
        static void Main(string[] args)
        {
            MyD my = null;
            my = (int i) =>
            {
                i--;
                Console.WriteLine("Begin {0}", i);
                if (i > 0)
                {
                    my(i);
                }
                Console.WriteLine("End {0}", i);
            };

            my(5);


        }
    }
}
