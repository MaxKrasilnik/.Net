using System;
using System.Collections.Generic;
using System.Text;

namespace HW4_Classes
{
    public class MyOrder
    {
        private string _description;
        private string _orderDate;
        private double _totalCost;
        private MyOrdersPosition _myOrdersPosition;
        private MyClient _client;
        private string _id;

        public MyOrder()
        {
            this._description = "";
            this._orderDate = "";
            this._totalCost = 0.0;
            this._myOrdersPosition = new MyOrdersPosition();
            this._client = new MyClient();
            this._id = "-1";
        }
        public MyOrder(string Adescription, string AorderDate, 
            double AtotalCost, MyOrdersPosition AmyOrdersPosition,
            MyClient Aclient, string Aid)
        {
            this._description = Adescription;
            this._orderDate = AorderDate;
            this._totalCost = AtotalCost;
            this._myOrdersPosition = AmyOrdersPosition;
            this._client = Aclient;
            this._id = Aid;
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return _orderDate;
            }

            set
            {
                _orderDate = value;
            }
        }
        public double TotalCost
        {
            get
            {
                return _totalCost;
            }

            set
            {
                _totalCost = value;
            }
        }
        public MyOrdersPosition MyOrdersPosition
        {
            get
            {
                return _myOrdersPosition;
            }

            set
            {
                _myOrdersPosition = value;
            }
        }
        public MyClient Client
        {
            get
            {
                return _client;
            }

            set
            {
                _client = value;
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
            return "Description: " + this._description + "OrderDate: " +
                this._orderDate + "TotalCost: " + this._totalCost +
        "MyOrdersPosition" + this._myOrdersPosition + "Client: " + this._client
        + "ID: " + this._id;
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as MyOrder;
            if (o == null)
            {
                return false;
            }

            return o._myOrdersPosition == this._myOrdersPosition;
        }

    }
}
