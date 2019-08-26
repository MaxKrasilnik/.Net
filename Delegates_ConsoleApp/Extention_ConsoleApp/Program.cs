using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_ConsoleApp
{
    public class Product
    {
        double price;
        double purchase_price;
        string productName;

        public Product()
        {
            price = 0.0;
            purchase_price=0.0;
            productName = " ";
        }
        public Product(double p, double purch, string pName)
        {
            price = p;
            purchase_price = purch;
            productName = pName;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Purchase_price
        {
            get { return purchase_price; }
            set { purchase_price = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        //public static string NotSame(this List<Product> list)
        //{
        //    Product inst = list[0];
        //    for (int i = 1, j=1; i < list.Count; i++)
        //    {
        //        Product temp = list[i];
        //        if (inst.productName.Equals(temp.ProductName))
        //            inst = list[j++];
        //    }

        //    return 
        //}

        public static double Income(this List<Product> list)
        {
            double pr = 0, purch = 0;
            for(int i=0; i< list.Count;i++)
            {
                Product inst = list[i];
                pr += inst.Price;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Product inst = list[i];
                purch += inst.Purchase_price;
            }
            return pr - purch;
        }

    }


    public static class IntListExtentionMethods
    {                                //this обязательно указывать для расширяющих методов
                                     //List<int> какого типа перед переменная
                                     //list переменная
        public static int GetMaxValue(this List<int> list)//расширяющие методы обязательно должны быть в статических классах
        {                                                 //расширяющие методы обязательно должны быть в статические
            int max = list[0];                            //расширяющие методы сразу доступны для того типа переменных, которые мы
            foreach (int i in list)                       //передаем в расширяющие методы
            {
                if (max < i)
                    max = i;
            }

            return max;
        }

        public static int GetMinValue(this List<int> list)//расширяющие методы обязательно должны быть в статических классах
        {
            int min = list[0];
            foreach (int i in list)
            {
                if (min > i)
                    min = i;
            }

            return min;
        }

        public static int GetWordCount(this string str, char c)
        {
            int count = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == c)
                    count++;
            }

            return count;
        }

        public static string ChangeFirstLetterCase(this string str)
        {
            char[] c = str.ToCharArray();
            c[0] = char.IsUpper(c[0]) ? char.ToLower(c[0]) : char.ToUpper(c[0]);

            return new string(c);
        }

        public static List<string> GetSubstrings(this string str, char c)
        {
            List<string> list = new List<string>();
            string[] arr = str.Split(c);

            list.AddRange(arr);

            foreach (string cur_elem in arr)
                list.Add(cur_elem);   

            return list;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> someNewList = new List<int>();
            someNewList.Add(1);
            someNewList.Add(2);
            someNewList.Add(3);

            Console.WriteLine(someNewList.Where(u => u == 3).First());

            Console.WriteLine(someNewList.GetMaxValue());

            string s = "stringsgsr";
            Console.WriteLine(s.GetWordCount('s'));

            Console.WriteLine(s.ChangeFirstLetterCase());


            string s1 = "ds ds sd fd";
            List<string> l = s1.GetSubstrings(' ');

            foreach (string s2 in l)
                Console.Write(s2);

            List<Product> prod = new List<Product>();

            prod.Add(new Product(1,2,"bananas"));
            prod.Add(new Product( 2, 3, "bananas2"));
            prod.Add(new Product(3, 4, "bananas3"));





        }
    }
}
