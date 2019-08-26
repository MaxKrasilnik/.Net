using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pr_13_Queue_Stack_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue0 = new Queue();
            queue0.Enqueue("Первый эл-т");

            Console.WriteLine(queue0.Peek());//queue0.Peek() узнаем какой след эл-т не удаляя его из коллекции
            Console.WriteLine(queue0.Count);
            queue0.Dequeue();//удаляем первый эл-т
            Console.WriteLine(queue0.Count);

            Stack stack0 = new Stack();
            stack0.Push("1");//добавляем первый эл-т
            stack0.Push("2");
            stack0.Push("3");
            stack0.Push("4");
            stack0.Push("5");

            if(stack0.Peek() is string)
            {
                stack0.Pop();//удаляем первый эл-т
            }

            while(stack0.Count > 0)
            {
                Console.WriteLine(stack0.Pop());//метод Pop удаляя возвращает удаляемый эл-т
            }

        }
    }
}
