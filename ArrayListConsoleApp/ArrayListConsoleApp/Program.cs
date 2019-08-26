using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            string s = "111111111";

            list.Add(s);
            list.Add(50);
            list.Add(new object());

            var anArray = new[] { "more", "or", "less" };
            list.AddRange(anArray);

            //вывод
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            list.Insert(3, "3333");

            list.InsertRange(5, anArray);

            list[0] = "string000000";


            //Методы удаления

            list.Remove("more");
            list.RemoveAt(3);

            list.RemoveRange(2, 3);//указываем от и до

            int count = list.Count;//кол-во эл-в в нашей коллекции

            if(list.Contains("or"))//Проверяет есть ли такой эл-т
            {
                Console.WriteLine("Этот эл-т есть");
            }

            int index = list.LastIndexOf("or");//ищет индекс опред эл-та

            list.Clear();//удаляет все эл-ты коллекции

            Console.WriteLine(list.Count);

            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            for(int i=0; i<list.Count; i++)
            {
                Console.Write(list[i]+"  ");
            }
            Console.Write("\n");

            IEnumerator enumerator = list.GetEnumerator();
            Console.WriteLine(enumerator.GetType());
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count <= 5) list.Add(6);
                Console.Write(list[i] + "  ");
            }
            Console.Write("\n");

            for (int i = 0; i < list.Count; i++)
            {
                if (list.Count > 5) list.RemoveAt(5);
                Console.Write(list[i] + "  ");
            }
            Console.Write("\n");

            M_Sort();

            Console.ReadKey();
        }

        public static void M_Sort()
        {
            var list = new ArrayList();

            list.Add(2);
            list.Add(3);
            list.Add(1);
            

            list.Sort();

            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            Console.Write("\n");

            list.Sort(new DescendingComparer());

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");

            list.Add(0);
            list.Add(9);
            list.Add(7);
            list.Add(8);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(6);

            list.Sort(new RandomingComparer());

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");






        }
    }

    public class DescendingComparer: IComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();//универсальный класс-обвертка, который сам сортирует
        public int Compare(object x, object y)//
        {

            int rezult = comparer.Compare(y, x);

            return rezult;
        }
        //public int Compare(object x, object y)
        //{
        //    int xx = (int)x;
        //    int yy = (int)y;

        //    if (xx < yy)
        //        return 1;

        //    if (xx > yy)
        //        return -1;

        //    return 0;
        //}
    }

    public class RandomingComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Random r = new Random();
            int rezult = r.Next(-1, 1);
            return rezult;
        }
    }
}
