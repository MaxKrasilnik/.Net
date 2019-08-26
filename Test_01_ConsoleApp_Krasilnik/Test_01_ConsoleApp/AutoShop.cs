using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test_01_ConsoleApp
{
    public class AutoShop:IComparable, ICloneable
    {
        readonly CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        private string _model;
        private double _price;
        private double _speed;
        private double _discount;
        private string _id;

        public override string ToString()
        {
            return $" model: {this._model}, price: {this._price}, speed: {this._speed}, discount: {this._discount}, id: {this._id}";
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as AutoShop;
            if (o == null)
            {
                return false;
            }

            return o._model == this._model;
        }
        public AutoShop()
        {
            this._model = "";
            this._price = 0.0;
            this._speed = 0.0;
            this._discount = 0.0;
            this._id = "";
        }
        public AutoShop(string model, double price, double speed, double discount, string id)
        {
            this._model = model;
            this._price = price;
            this._speed = speed;
            this._discount = discount;
            this._id = id;
        }
        public string Model
        {
            get
            {
                return this._model;
            }
            set
            {
                this._model = value;
            }
        }
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        public double Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }
        public double Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public void Print()
        {
            Console.WriteLine($"model: {this._model}");
            Console.WriteLine($"price: {this._price}");
            Console.WriteLine($"speed: {this._speed}");
            Console.WriteLine($"discount: {this._discount}");
            Console.WriteLine($"id: {this._id}");
            Console.WriteLine("\n");
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return -1;

            AutoShop p = obj as AutoShop;

            if (p == null) return -1;

            if (int.Parse(this._id) == int.Parse(p._id))
                return 0;

            if (int.Parse(this._id) > int.Parse(p._id))
                return 1;

            return -1;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int Compare(object x, object y)
        {
            int rez = comparer.Compare(y, x);
            return rez;
        }

        
    }
}
