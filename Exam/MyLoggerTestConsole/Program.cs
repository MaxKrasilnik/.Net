using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLoggerTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "";
            //FileStream stream = new FileStream(@"D:\MAX.txt", FileMode.Create, FileAccess.Write);
            //byte[] array = System.Text.Encoding.Default.GetBytes(s);
            //stream.Write(array, 0, array.Length);
            //Console.WriteLine("Текст записан в файл");
            //stream.Close();

            //Logger log = new Logger();
            //log.WriteProtocol("D", DateTime.Now.ToString(), "ТЕСТ ЛОГА", "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");

            //Console.WriteLine(log[0]);

            MyXmlLogger myXml = new MyXmlLogger();
            myXml.WriteProtocol("D:\\", DateTime.Now.ToString(), "ТЕСТ ЛОГА", 
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");
            myXml.WriteProtocol("D:\\", DateTime.Now.ToString(), "ТЕСТ ЛОГА",
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");
            myXml.WriteProtocol("D:\\", DateTime.Now.ToString(), "ТЕСТ ЛОГА",
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");

            myXml.WriteProtocol( DateTime.Now.ToString(), "ТЕСТ ЛОГА",
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");
            myXml.WriteProtocol( DateTime.Now.ToString(), "ТЕСТ ЛОГА",
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");
            myXml.WriteProtocol( DateTime.Now.ToString(), "ТЕСТ ЛОГА",
                "MyLoggerTestConsole: Program.cs : Main", "Запись в лог на диске d");

        }
    }
}
