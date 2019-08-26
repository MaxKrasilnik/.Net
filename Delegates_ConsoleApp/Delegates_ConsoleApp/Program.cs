using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_ConsoleApp
{
    public delegate void MyDelegate();//сигнатура метода и делегата должны быть одинаковыми
    public delegate void MyDelegate2(string s);
    public delegate void MyDelegate3(string s);
    public delegate int MyDelegate4(int a, int b);
    public delegate int L1Delegate(int a);
    public delegate void L2Delegate();

    public static class MyStaticClass
    {
        public static void Method()//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Show");
        }

        public static void Method2(string s)//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Hello "+s);
        }
    }

    public  class MyClass
    {
        

        public static void Method3(string s)//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Hello " + s);
        }
    }




    class Program
    {
        public static void Method1()//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Method1");
        }

        public static void Method2()//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Method2 ");
        }

        public static void Method3()//сигнатура метода и делегата должны быть одинаковыми
        {
            Console.WriteLine("Method3 ");
        }


       
        /// //////////////////////////////////////////////////////////////////////////////////
        
           public static void M1()
        {   //Лямбда-Метод
            L1Delegate l1_d = delegate (int x) { return x * 2; };
            Console.WriteLine(l1_d(10));

            
            //Лямбда-Оператор
            l1_d = (x) => { return x * 2; };
            Console.WriteLine(l1_d(10));


            //Лямбда-Выражение
            l1_d = x => x * 2;
            Console.WriteLine(l1_d(10));

            L2Delegate l2_d;
            l2_d = delegate { Console.WriteLine("Hello"); };

            l2_d += () => { Console.WriteLine("Hello2"); };

            l2_d += () =>  Console.WriteLine("Hello3");

            l2_d();
        }
              
              /// //////////////////////////////////////////////////////////////////////
              
        

        static void Main(string[] args)
        {

            MyDelegate myDelegate = new MyDelegate(MyStaticClass.Method);//равносильно строке 28
            MyDelegate m = MyStaticClass.Method;//равносильно строке 27

            myDelegate.Invoke();//равносильно строке 32
            myDelegate();//равносильно строке 31

            MyDelegate2 myDelegate2 = new MyDelegate2(MyStaticClass.Method2);

            myDelegate2("Alex");

            MyClass myClass = new MyClass();
            MyDelegate3 deleg = new MyDelegate3(MyClass.Method3);
            deleg("Roma");

            MyDelegate d0;//назвал сокращенно делегат d
            MyDelegate d1 = new MyDelegate(Method1);
            MyDelegate d2 = new MyDelegate(Method2);
            MyDelegate d3 = new MyDelegate(Method3);

            d0 = d1 + d2 + d3;

            d0();

            Console.WriteLine("Enter 1 - 7");
            string choise = Console.ReadLine();

            switch(choise)
            {
                case "1":
                    d1.Invoke();
                    break;
                case "2":
                    d2.Invoke();
                    break;
                case "3":
                    d3.Invoke();
                    break;
                case "4":
                    MyDelegate d4 = d0 - d1;
                    d4();
                    break;
                case "5":
                    MyDelegate d5 = d0 - d2;
                    d5();
                    break;
                case "6":
                    MyDelegate d6 = d0 - d3;
                    d6();
                    break;
                case "7":
                    d0();
                    break;
            }

            MyDelegate d10 = new MyDelegate(delegate { Console.WriteLine("Hello!!!"); Console.WriteLine("Hello!!!!!!!!!!!!!"); });//равносильно строкам 115-119
            d10();

            MyDelegate d11 = delegate//равносильно строке 112
            {//равносильно строке 112
                Console.WriteLine("Hello!!!");//равносильно строке 112
                Console.WriteLine("Hello!!!!!!!!!!!!!");//равносильно строке 112
            };//равносильно строке 112

            d11();

        int sum1 = 1, sum2 = 2, sum = 0;

        MyDelegate4 d31 = delegate (int a, int b) { return a + b; };

            M1();

           
               


            
        }
    }
}
