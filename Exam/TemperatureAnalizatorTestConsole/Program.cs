using System;
using System.IO;

namespace TemperatureAnalizatorTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureAnalizator t = new TemperatureAnalizator();
            t.FindValue(1.0);
            t.FindValue(2);
            t.FindValue("3");
            t.FindValue(4.0, 4.5);
        }
        
    }
    
}
