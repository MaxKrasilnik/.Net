using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_07_OverOperation
{
    public class MyPoint
    {
        public int x, y, z;
        public MyPoint(int x=0, int y=0, int z=0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return "Point: " + this.x + " " + this.y + " " + this.z;
        }

        public static MyPoint operator +(MyPoint p1, MyPoint p2)
        {
            MyPoint p = new MyPoint();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            p.z = p1.z + p2.z;
            return p;
        }

        public static MyPoint operator +(MyPoint p1, int k)
        {
            MyPoint p = new MyPoint();
            p.x = p1.x + k;
            p.y = p1.y + k;
            p.z = p1.z + k;
            return p;
        }

        public static string operator +(MyPoint p1, string s)
        {

            return s + " " + p1.x + " " + p1.y + " " + p1.z;
        }

        public static MyPoint operator -(MyPoint p1)
        {

            return new MyPoint(z: -p1.z, x: -p1.x, y: -p1.y);
        }

        public static MyPoint operator +(MyPoint p1)
        {

            return new MyPoint(z: p1.z+10, x: p1.x+10, y: p1.y+10);
        }

        public static MyPoint operator ++(MyPoint p1)
        {

            return new MyPoint(z: p1.z + 1, x: p1.x + 1, y: p1.y + 1);
        }

        public static bool operator ==(MyPoint p1, MyPoint p2)
        {
            if ((p1.x == p2.x) && (p1.y == p2.y) && (p1.z == p2.z))
                return true;

            return false;
        }

        public static bool operator !=(MyPoint p1, MyPoint p2)
        {
            if ((p1.x != p2.x) && (p1.y != p2.y) && (p1.z != p2.z))
                return true;

            return false;
        }

        public static bool operator true(MyPoint p1)
        {
            if ((p1.x > 0) && (p1.y >0) && (p1.z >0))
                return true;

            return false;
        }

        public static bool operator false(MyPoint p1)
        {
            if ((p1.x <= 0) && (p1.y <= 0) && (p1.z <= 0))
                return true;

            return false;
        }

        public static bool operator !(MyPoint p1)
        {
            if ((p1.x > 0) && (p1.y > 0) && (p1.z > 0))
                return false;

            return true;
        }

        public static MyPoint operator &(MyPoint p1, MyPoint p2)
        {
            if ((p1.x > 0) && (p1.y > 0) && (p1.z > 0) & (p2.x > 0) && (p2.y > 0) && (p2.z > 0))
                return p1;

            return new MyPoint(1,1,1);
        }

        public static MyPoint operator |(MyPoint p1, MyPoint p2)
        {
            if ((p1.x > 0) || (p1.y > 0) || (p1.z > 0) | (p2.x > 0) || (p2.y > 0) || (p2.z > 0))
                return p1;

            return new MyPoint(-1, -1, -1);
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            MyPoint point1 = new MyPoint(1, 12, -4);
            MyPoint point2 = new MyPoint(0, -3, 18);

            Console.WriteLine("#1  "+ point1.ToString());
            Console.WriteLine("#2  "+ point2.ToString());

            MyPoint point3 = point1 + point2;
            Console.WriteLine("#3  "+ point3.ToString());
            point3 = point3 + 5;
            Console.WriteLine("+int  " + point3.ToString());
            string s = point3 + "abc";
            Console.WriteLine("+string  " + s);
            s = "abc"+ point3;
            Console.WriteLine("+ToString  " + s);
            MyPoint point4 = -point3;
            Console.WriteLine("-MyPoint  " + point4.ToString());
            point4 = +point4;
            Console.WriteLine("+MyPoint  " + point4.ToString());
            point4++;
            Console.WriteLine("MyPoint++  " + point4.ToString());
            ++point4;
            Console.WriteLine("++MyPoint  " + point4.ToString());

            Console.WriteLine("point4 == point1  " + (point4 == point1));
            Console.WriteLine("point4 == point4  "+(point4 == point4));
            Console.WriteLine("point4 != point4  "+(point4 != point4));
            Console.WriteLine("point4 != point1  "+(point4 != point1));

            MyPoint point5 = new MyPoint(1, 2, 3);
            if (point5)
                Console.WriteLine("Точки > 0");
            else
                Console.WriteLine("Точки < 0");

            Console.WriteLine(!point5);


        }
    }
}
