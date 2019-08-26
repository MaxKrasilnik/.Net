using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace Pr_OtherDictionary_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
                                  //исп когда не знаешь сколько будет эл-тов в коллекции
            var emailLookup = new HybridDictionary();
                     //обычно исп ListDictionary
                                //OrderedDictionary еще и сортирует

            emailLookup.Add("a@a.ua", "Иванов Иван");
            //ключ уникален 
            emailLookup["a@a.ua"] = "Петров Петр";
            //его значение может повторятся
            emailLookup["a1@a.ua"] = "Сидоров Петр";
            
            foreach (DictionaryEntry n in emailLookup)
            {
                Console.WriteLine(n.Value);
            }

            foreach (DictionaryEntry n in emailLookup)
            {
                Console.WriteLine(n.Key + "  " + n.Value);
            }

            //для программирования контроллеров
            BitArray bits = new BitArray(3);
            bits[0] = false;
            bits[1] = true;
            bits[2] = false;
            Console.WriteLine(bits.Length);

            bits.Length = 4;
            bits[3] = true;
            Console.WriteLine(bits.Length);

            BitArray bits2 = new BitArray(4);
            bits2[0] = false;
            bits2[1] = true;
            bits2[2] = false;
            bits2[3] = true;
            Console.WriteLine(bits.Length);

            BitArray xorBits = bits.Xor(bits2);

            var vector = new BitVector32(0);

            int firstBit = BitVector32.CreateMask();
            int secondBit = BitVector32.CreateMask(firstBit);

            vector[firstBit] = true;
            vector[secondBit] = true;

            Console.WriteLine("{0} должно быть 3", vector.Data);
            Console.WriteLine(vector.ToString());
        }
    }
}
