using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoggerTestConsole
{
    interface IMyLogger
    {
        void WriteProtocol(string logname, string date_time, string action, string code_line, string log_text);
        void WriteProtocol(string date_time, string action, string code_line, string log_text);
    }
}
