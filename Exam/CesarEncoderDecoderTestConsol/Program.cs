using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CesarEncoderDecoderTestConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 3;
            string s = "123456";
            FileStream stream = new FileStream(@"D:\MAX.txt", FileMode.Create, FileAccess.Write);
            byte[] array = System.Text.Encoding.Default.GetBytes(s);
            stream.Write(array, 0, array.Length);
            Console.WriteLine("Текст записан в файл");
            stream.Close();

            CesarEncoder enc = new CesarEncoder();
            enc.Encoder(@"D:\MAX.txt", step);
            CesarDecoder dec = new CesarDecoder();
            dec.Decoder(@"D:\MAX.txt", step);

        }
    }
}
