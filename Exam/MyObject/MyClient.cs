using System;
using System.Collections.Generic;
using System.Text;

namespace HW4_Classes
{
    public class MyClient
    {
        private string _name;
        private string _phone;
        private string _email;
        private MyAccount _account;
        private int _age;
        private string _regionInfo;
        private string _id;

        public MyClient(string s)
        {
            this._name = s;
        }

        public MyClient()
        {
            this._name = "";
            this._phone = "";
            this._email = "";
            this._account = new MyAccount();
            this._age = -1;
            this._regionInfo = "";
            this._id = "-1";
        }
        public MyClient(string Aname, string Aphone, string Aemail, 
            MyAccount Aaccount, int Aage, string AregionInfo, string Aid)
        {
            this._name = Aname;
            this._phone = Aphone;
            this._email = Aemail;
            this._account = Aaccount;
            this._age = Aage;
            this._regionInfo = AregionInfo;
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
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public MyAccount Account
        {
            get
            {
                return _account;
            }

            set
            {
                _account = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        public string RegionInfo
        {
            get
            {
                return _regionInfo;
            }

            set
            {
                _regionInfo = value;
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
            return "Name: " + this._name + "Phone: " + this._phone + "Email: " +
                this._email + "MyAccount: " + this._account + "Age: " + this._age
                + "RegionInfo" + this._regionInfo + "ID: " + this._id;
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as MyClient;
            if (o == null)
            {
                return false;
            }

            return o._account == this._account;
        }
    }
}
