using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Pr_14_NameValueCollection_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var nv = new NameValueCollection
            {
                { "Key", "Some Text" },
                { "Key", "More Text" }
            };

            foreach (string s in nv.GetValues("Key"))
                Console.WriteLine(s);

            nv["First"] = "1st";
            nv["First"] = "FIRST";

            Console.WriteLine(nv.GetValues("First").Length);

            nv.Add("Second", "2nd");
            nv.Add("Second", "SECOND");

            foreach (string s in nv.GetValues("Second"))
                Console.WriteLine(s);

            var appSettings = ConfigurationManager.AppSettings;

            foreach (string appSetting in appSettings)
                Console.WriteLine("{0}: {1}", appSettings, appSettings[appSetting]);

            Console.WriteLine(appSettings["SomeKey"]);
        }
    }
}