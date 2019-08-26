using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedList
{
    public class DescendingComparer: IComparer
    {
        CaseInsensitiveComparer comp = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comp.Compare(x, y);
        }

    }
}
