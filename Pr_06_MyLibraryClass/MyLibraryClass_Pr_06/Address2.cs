using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass_Pr_06
{
    public class Address2 : Address
    {
        private string nbrRoom;

        public string NbrRoom
        {
            get
            {
                return nbrRoom;
            }
            set
            {
                nbrRoom = value;
            }
        }

        public Address2(string PostIndex, string City, string Street, string NumberHouse, string NbrRoom) :base(PostIndex, City, Street, NumberHouse)
        {
            this.nbrRoom = NbrRoom;
        }


        public override string ToString()
        {
            string rez = base.ToString();

            if (!string.IsNullOrEmpty(this.nbrRoom))
            {
                rez = rez + this.separator1 + this.nbrRoom;
            }


            return rez;
        }
    }
}
