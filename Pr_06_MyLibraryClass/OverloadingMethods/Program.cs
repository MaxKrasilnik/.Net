using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibraryClass_Pr_06;

namespace OverloadingMethods
{

    class MyClass
    {
        private string _username;
        private string _password;

       
        public MyClass(string Username)
        {
            this._username = Username;
            this._password = string.Empty;
        }

        public MyClass(string Username, string Password)
        {
            this._username = Username;
            this._password = Password;
        }

        public void Method1()
        {
            Console.WriteLine("Пустой метод\n");
        }

        public void Method1(string nameuser)
        {
            Console.WriteLine("Имя пользователя {0}", nameuser);
        }

        public void Method1(string nameuser, string password)
        {
            Method1(nameuser);
            Console.WriteLine("Пароль {0}", password);
        }
    }


    class MyArr
    {
        public int[] arr;
        public int length;


        public MyArr()
        {
            arr = new int[1];
            length = 0;
        }
        public MyArr(int Size)
        {
            arr = new int[Size];
            length = Size;
        }

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index]=value; }
        }

        //public int this[double index]
        //{
        //    get { return arr[(int)Math.Round(index)]; }
        //    set { arr[(int)Math.Round(index)] = value; }
        //}

        public int this[string index]
        {
            get
            {
                if (index == "first") return arr[1];
                else return arr[0];
            }

            set
            {
                arr[0] = 10;
            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass("Max");
            m1.Method1();
            m1.Method1("User1");
            m1.Method1("user1", "12345");

            MyArr arr = new MyArr();
            arr[0] = 5;

            Address add1 = new Address("abc", "abc", "abc", "abc");
            add1[0] = "610444";
            Console.WriteLine(add1[0]);
            add1["city"] = "Kharkov";
            Console.WriteLine(add1["city"]);

            //arr[1.2] = 7;
            //arr["first"] = 10;
            //Console.WriteLine(arr["first"]);

        }
    }
}
