using System;
using System.Collections.Generic;
using System.Text;


namespace HW4_Classes
{
    public class MyAccount
    {
        private MyClient _client;
        private string _accountNumber;
        private string _id;

        public MyAccount()
        {
            this._client = new MyClient(); ;
            this._accountNumber = "-1";
            this._id = "-1";
        }
        public MyAccount(MyClient Aclient, string AaccountNumber, string Aid)
        {
            this._client = Aclient;
            this._accountNumber = AaccountNumber;
            this._id = Aid;
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
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }

            set
            {
                _accountNumber = value;
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
            return "Client: " + this._client + "AccountNumber: "
                + this._accountNumber;
        }
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var o = obj as MyAccount;
            if (o == null)
            {
                return false;
            }

            return o._accountNumber == this._accountNumber;
        }



    }
}
