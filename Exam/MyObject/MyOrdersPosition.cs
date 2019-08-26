using System;
using System.Collections.Generic;
using System.Text;

namespace HW4_Classes
{
    public class MyOrdersPosition
    {
        private MyProduct _product;
        private double _price;
        private int _count;
        private MyOrder _order;
        private string _id;

        public MyOrdersPosition()
        {
            this._product = new MyProduct();
            this._price = 0.0;
            this._count = 0;
            this._order = new MyOrder();
            this._id = "-1";
        }
        public MyOrdersPosition(MyProduct Aproduct, double Aprice, int Acount,
            MyOrder Aorder, string Aid)
        {
            this._product = Aproduct;
            this._price = Aprice;
            this._count = Acount;
            this._order = Aorder;
            this._id = Aid;
        }
        public MyProduct Product
        {
            get
            {
                return _product;
            }

            set
            {
                _product = value;
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
        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count = value;
            }
        }
        public MyOrder Order
        {
            get
            {
                return _order;
            }

            set
            {
                _order = value;
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
            return "Product: " + this._product + "Price: " + this._price +
        "Count: " + this._count + "Order: " + this._order + "ID: " + this._id;
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as MyOrdersPosition;
            if (o == null)
            {
                return false;
            }

            return o._order == this._order;
        }
    }
}
