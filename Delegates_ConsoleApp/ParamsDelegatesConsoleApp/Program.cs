using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDelegatesConsoleApp
{
    delegate void Delegate2();
    delegate Delegate2 Delegate1();

    delegate string D1();
    delegate string D2();
    delegate string D3();
    delegate D3 Functional(D1 d1, D2 d2);
    class Program
    {
        public static D3 MethodF(D1 d1, D2 d2)
        {
            return delegate { return d1.Invoke() + d2.Invoke(); };
        }

        public static string M1() { return "Hello"; }
        public static string M2() { return "world"; }

        public static void Method2()//2
        {
            Console.WriteLine("Hello2");
        }

        public static Delegate2 Method1()//1
        {
            return new Delegate2(Method2);
        }
        static void Main(string[] args)
        {
            Delegate1 d1 = new Delegate1(Method1);
            Delegate2 d2 = d1();

            d2();

            Functional func = new Functional(MethodF);

            D3 d3 = func.Invoke(new D1(M1), new D2(M2));

            Console.WriteLine(d3.Invoke());




        }
    }
}
