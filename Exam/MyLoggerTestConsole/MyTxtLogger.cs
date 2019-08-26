using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoggerTestConsole
{
    class MyTxtLogger : IMyLogger
    {
        public void WriteProtocol(string logname, string date_time, string action, string code_line, string log_text)
        {
            if (logname[0] == 'C' || logname[0] == 'D' ||
                logname[0] == 'E' || logname[0] == 'F')
            {
                string s = logname + " | " + date_time + " | " + action +
                    " | " + code_line + " | " + log_text;

                FileStream stream = new FileStream(@"D:\MAX.txt", FileMode.Append, FileAccess.Write);
                byte[] array = System.Text.Encoding.Default.GetBytes(s);
                stream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
                stream.Close();
            }
            else
                Console.WriteLine("The disk with this name is not found");
        }

        private int count = 1;
        public void WriteProtocol(string date_time, string action, string code_line, string log_text)
        {
            string s = "C:\new" + count++ +".txt" + " | " + date_time + " | " + action + " | " +
                code_line + " | " + log_text;
            FileStream stream = new FileStream(@"D:\MAX.txt", FileMode.Append, FileAccess.Write);
            byte[] array = System.Text.Encoding.Default.GetBytes(s);
            stream.Write(array, 0, array.Length);
            Console.WriteLine("Текст записан в файл");
            stream.Close();

        }
    }
}
