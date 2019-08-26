using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_ConsoleApp
{
    class Customer
    {
        public Person _Person { get; set; }
        public string _Mail { get; set; }
        public string _Phone { get; set; }
        public string _Region { get; set; }

        public Customer(Person p, string m, string ph, string r)
        {
            _Person = p;
            _Mail = m;
            _Phone = ph;
            _Region = r;
    }
        public override string ToString()
        {
            return "\nPERSON\n" + _Person + "\n_Mail: " + _Mail + "\n_Phone: " + _Phone + "\n_Region: " + _Region;
        }
    }
}
