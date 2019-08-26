using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyLoggerTestConsole
{
    class MyXmlLogger
    {
        private int row = 1;
        public void WriteProtocol(string logname, string date_time, string action, string code_line, string log_text)
        {
            if (logname[0] == 'C' || logname[0] == 'D' ||
                logname[0] == 'E' || logname[0] == 'F')
            {
                XDocument xdoc = XDocument.Load("LOGGER.xml");
                
                // создаем первый элемент
                XElement log_row = new XElement("log_row");
                // создаем атрибут
                XAttribute rownum = new XAttribute("rownum", $"{row++}");
                XAttribute dateTime = new XAttribute("date_time", $"{date_time}");
                XAttribute actionAtr = new XAttribute("action", $"{action}");
                XAttribute codeRowAtr = new XAttribute("code_row", $"{code_line}");
                XText logTextAtr = new XText($"{log_text}");
                log_row.Add(rownum);
                log_row.Add(dateTime);
                log_row.Add(actionAtr);
                log_row.Add(codeRowAtr);
                log_row.Add(logTextAtr);

                XElement log = xdoc.Element("log");
                log.Add(log_row);
                xdoc.Save("LOGGER.xml");
            }
            else
                Console.WriteLine("The disk with this name is not found");
        }

        private int count = 1;
        public void WriteProtocol(string date_time, string action, string code_line, string log_text)
        {
            XDocument xdoc = XDocument.Load("LOGGER.xml");

            // создаем первый элемент
            XElement log_row = new XElement("log_row");
            // создаем атрибут
            XAttribute rownum = new XAttribute("rownum", $"{row++}");
            XAttribute dateTime = new XAttribute("date_time", $"{date_time}");
            XAttribute actionAtr = new XAttribute("action", $"{action}");
            XAttribute codeRowAtr = new XAttribute("code_row", $"{code_line}");
            XText logTextAtr = new XText($"{log_text}");
            log_row.Add(rownum);
            log_row.Add(dateTime);
            log_row.Add(actionAtr);
            log_row.Add(codeRowAtr);
            log_row.Add(logTextAtr);

            XElement log = xdoc.Element("log");
            log.Add(log_row);
            xdoc.Save("LOGGER.xml");
        }
    }
}
