using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CesarEncoderDecoderTestConsol
{
    class CesarDecoder
    {
        public void Decoder(string str, int step)
        {
            FileStream stream = File.OpenRead(@"D:\MAX.txt");
            byte[] array = new byte[stream.Length];
            stream.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);
            Console.WriteLine("Текст из файла: {0}", textFromFile);
            stream.Close();

            char[] arr = textFromFile.ToCharArray();

            for (int i = 0; i < textFromFile.Length; i++)
            {
                arr[i] = (char)((int)arr[i] - step);
            }

            string rez = "";
            for (int i = 0; i < arr.Length; i++)
            {
                rez += arr[i];
            }
            Console.WriteLine("Текст {0} с шагом {1} расшифрован", rez, step);

            FileStream streamRez = new FileStream(@"D:\MAX.txt", FileMode.Open, FileAccess.Write);
            array = System.Text.Encoding.Default.GetBytes(rez);
            streamRez.Write(array, 0, array.Length);
            streamRez.Close();
        }
    }
}
