using HW4_Classes;
using System;
using System.Collections.Generic;

namespace MyClientsGListTestConsol
{
    
    delegate bool Delegate2(string s);
    class Program
    {
        //public static bool PrintClient(MyClient client, string name)
        //{
        //    return client.Name == name;
        //}
        static void Main(string[] args)
        {
            //Delegate d = PrintClient;
            //MyClient c = new MyClient("Петр");
            //MyClient c1 = new MyClient("Иван");
            //List<MyClient> list = new List<MyClient>();
            //list.Add(c1);

            //MyClientsGList m = new MyClientsGList();
            //m.MYClients = list;
            //d(c, d => d.);

            Delegate2 d = delegate (string s) { return s=="Иван"; };
            d.Method
            Console.WriteLine(l1_d(10));


            //Лямбда-Оператор
            l1_d = (x) => { return x * 2; };
            Console.WriteLine(l1_d(10));


            //Лямбда-Выражение
            l1_d = x => x * 2;


        }
    }
}
