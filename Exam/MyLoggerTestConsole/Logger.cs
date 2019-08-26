using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoggerTestConsole
{
    class Logger:IMyLogger, IDisposable
    {
        private bool USE_C;
        private bool USE_D;
        private bool USE_F;
        private bool USE_E;
        private string[] info = new string[1];

        public Logger()
        {
            USE_C = USE_D = USE_F = USE_E = false;
            info[0] = "123";
        }
        public Logger(int n)
        {
            USE_C = USE_D = USE_F = USE_E = false;
            info = new string[n];

            for (int i = 0; i < info.Length; i++)
                info[i] = "123";
        }

        #region Auto-properties, Overloading indexators
        public bool UseC
        {
            get { return USE_C; }
            set { USE_C = value; }
        }
        public bool UseD
        {
            get { return USE_D; }
            set { USE_D = value; }
        }
        public bool UseF
        {
            get { return USE_F; }
            set { USE_F = value; }
        }
        public bool UseE
        {
            get { return USE_E; }
            set { USE_E = value; }
        }
        public string this[int index]
        {
            get
            {
                return info[index];
            }
            set
            {
                info[index] = value.ToString();
            }
        }
        public string this[string index]
        {
            get
            {
                return info[int.Parse(index)];
            }
            set
            {
                info[int.Parse(index)] = value;
                
            }
        }
        #endregion

        public void WriteProtocol(string logname, string date_time, string action, string code_line, string log_text)
        {
            bool isEmpty = false;

            for (int i = 0; i < info.Length; i++)
                if (info[i] == "123")
                {
                    isEmpty = true;

                    if (logname[0] == 'C')
                    {
                        UseC = true;
                        info[i] = logname + " | " + date_time + " | " + action +
                        " | " + code_line + " | " + log_text;
                    }
                    else if (logname[0] == 'D')
                    {
                        UseD = true;
                        info[i] = logname + " | " + date_time + " | " + action +
                        " | " + code_line + " | " + log_text;
                    }
                    else if (logname[0] == 'E')
                    {
                        UseE = true;
                        info[i] = logname + " | " + date_time + " | " + action +
                        " | " + code_line + " | " + log_text;
                    }
                    else if (logname[0] == 'F')
                    {
                        UseF = true;
                        info[i] = logname + " | " + date_time + " | " + action +
                        " | " + code_line + " | " + log_text;
                    }
                    else
                    {
                        Console.WriteLine("The disk with this name is not found");
                    }

                    break;
                }

            if (isEmpty == false)
                Console.WriteLine("The array is full");
        }



        private int count = 1;
        public void WriteProtocol(string date_time, string action, string code_line, string log_text)
        {
            bool isEmpty = false;

            for (int i = 0; i < info.Length; i++)
                if (info[i] == "123")
                {
                    isEmpty = true;

                    info[i] = "C:\new"+ count++ + ".txt" + " | " + date_time + " | " + action + " | " + code_line + " | " + log_text;
                    UseC = true;
                    break;
                }

            if (isEmpty == false)
                Console.WriteLine("The array is full");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool flag)
        {
            if (!flag)
            {
                if (flag)
                {
                    Console.Error.WriteLine("Disposing of managed resources.");
                }
                Console.WriteLine("Disposing of unmanaged resources.");
            }
            flag = true;
        }
    }
}
