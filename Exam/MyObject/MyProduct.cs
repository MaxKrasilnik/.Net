using System;
using System.Collections.Generic;
using System.Text;

namespace HW4_Classes
{
    public class MyProduct
    {
        private string _name;
        private double _price;
        private string _id;

        public MyProduct()
        {
            this._name = "";
            this._price = 0.0;
            this._id = "-1";
        }
        public MyProduct(string Aname, double Aprice, string Aid)
        {
            this._name = Aname;
            this._price = Aprice;
            this._id = Aid;
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
        public string ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public override string ToString()
        {
            return "Name: " + this._name + "Price: " + this._price
                + "ID: " + this._id;
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as MyProduct;
            if (o == null)
            {
                return false;
            }

            return o._name == this._name;
        }

    }
}
