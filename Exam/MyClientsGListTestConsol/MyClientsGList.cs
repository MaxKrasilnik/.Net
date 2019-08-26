using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HW4_Classes;

namespace MyClientsGListTestConsol
{
    delegate bool Delegate(MyClient client, string name);
    public class MyClientsGList: IEnumerable, IEnumerator, IClonable
    {
        private List<MyClient> myClients;
        private int index;


        public void PrintClient(Predicate<MyClient> predicate)
        {
            var client = predicate.;
            foreach (var item in client)
            {
                WriteLine(item);
            }
        }

        public List<MyClient> MYClients
        {
            get
            {
                return myClients;
            }
            set
            {
                myClients = value;
            }
        }

        public MyClientsGList()
        {
            myClients = new List<MyClient>();
            index = -1;
        }
        public object Current
        {
            get
            {
                return myClients[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return myClients.GetEnumerator();
        }
        public bool MoveNext()
        {
            if (index == myClients.Count - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }
        public void Reset()
        {
            index = -1;
        }
        public object Clone()
        {
            return new MyClientsGList { myClients = this.myClients, index = this.index };
        }


    }
}
