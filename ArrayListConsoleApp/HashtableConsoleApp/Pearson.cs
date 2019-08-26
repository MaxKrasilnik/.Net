using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableConsoleApp
{
    class Pearson
    {
        public string name;

        public Pearson(string n)
        {
            name = n;
        }

        public override string ToString()
        {
            return $"Pearson name: {this.name}";
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var o = obj as Pearson;
            if(o==null)
            {
                return false;
            }

            return o.name == this.name;
        }
    }
}
