using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashtableConsoleApp
{
    class InsensitiveComparer: IEqualityComparer
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public new bool Equals(object x, object y)
        {
            return comparer.Compare(x, y) == 0;
        }

        public  int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
