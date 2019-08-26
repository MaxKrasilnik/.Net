using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass_Pr_06
{
    public partial class Address
    {
        private string postIndex;
        private string city;
        private string street;
        private string numberHouse;
        protected string separator1 = " ,";

        public string PostIndex
        {
            get
            {
                return postIndex;
            }
            set
            {
                postIndex = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string NumberHouse
        {
            get
            {
                return numberHouse;
            }
            set
            {
                numberHouse = value;
            }
        }

        public Address(string PostIndex, string City, string Street, string numberHouse)
        {
            this.postIndex = PostIndex;
            this.city = City;
            this.street = Street;
            this.numberHouse = numberHouse;
        }


        public string this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0:
                        return this.postIndex;
                        break;

                    case 1:
                        return this.city;
                        break;

                    case 2:
                        return this.street;
                        break;

                    case 3:
                        return this.numberHouse;
                        break;

                    default:
                        return string.Empty;
                }
                
            }

            set
            {
                switch (index)
                {
                    case 0:
                        this.postIndex = value;
                        break;

                    case 1:
                        this.city = value;
                        break;

                    case 2:
                         this.street = value;
                        break;

                    case 3:
                         this.numberHouse = value;
                        break;

                    default:
                        break;
                        
                }
            }
        }

        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "postIndex":

                        return this.postIndex;
                        break;

                    case "city":
                        return this.city;
                        break;

                    case "street":
                        return this.street;
                        break;

                    case "numberHouse":
                        return this.numberHouse;
                        break;

                    default:
                        return string.Empty;
                }

            }

            set
            {
                switch (index)
                {
                    case "postIndex":
                        this.postIndex = value;
                        break;

                    case "city":
                        this.city = value;
                        break;

                    case "street":
                        this.street = value;
                        break;

                    case "numberHouse":
                        this.numberHouse = value;
                        break;

                    default:
                        break;

                }
            }
        }


    }

    public partial class Address
    {
        public override string ToString()
        {
            string rez = postIndex;
            if(!string.IsNullOrEmpty(this.postIndex))
            {
                rez = postIndex;
            }

            if (!string.IsNullOrEmpty(this.city))
            {
                rez = rez + separator1+this.city;
            }


            return rez;
        }

        //public static bool operator ==(Address a1, Address a2)
        //{
        //    if (a1 == null || a2 == null) return false;
        //    else return a1.Equals(a2);
        //}

        //public static bool operator !=(Address a1, Address a2)
        //{
        //    if (a1 == null || a2 == null) return false;
        //    else return !a1.Equals(a2);
        //}
    }


    public partial class Address
    {
        public override bool Equals(object obj)//для сравнения двух экземпляров разных классов
        {
            if(obj==null)
                return false;

            Address a = obj as Address;
            //Address a = (Address)obj;

            if (a == null)
                return false;

            return string.Compare(a.postIndex, this.postIndex) == 0
                && string.Compare(a.city, this.city) == 0
                && string.Compare(a.street, this.street) == 0
                && string.Compare(a.numberHouse, this.numberHouse) == 0;
        }

        public bool Equals(Address obj)//для сравнения двух экземпляров одного и того же класса
        {
            if (obj == null)
                return false;

            Address a = obj as Address;
            //Address a = (Address)obj;

            if (a == null)
                return false;

            return string.Compare(a.postIndex, this.postIndex) == 0
                && string.Compare(a.city, this.city) == 0
                && string.Compare(a.street, this.street) == 0
                && string.Compare(a.numberHouse, this.numberHouse) == 0;
        }
    }



    
}
