using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_ConsoleApp
{
    class MyCustomers:IEnumerable, IEnumerator //IEnumerator-тетенька которая перебирает   IEnumerable-отдает элемент
    {
        private List<Customer> customers = new List<Customer>();
        int pos = -1;

        #region Constructor
        public MyCustomers(List<Customer> c)
        {
            customers = c;
        }
        public MyCustomers(Customer c)
        {
            customers.Add(c);
        }
        #endregion
        public void Add(Customer c)
        {
            customers.Add(c);
        }
        public override string ToString()
        {
            string str= "";
            foreach(Customer c in customers)
            {
                str += c.ToString();
            }

            return str;
        }

        public List<Customer> SortByAge()
        {
            List<Customer> l = customers.ToList<Customer>();
            return customers.OrderBy(u => u._Person.Age).ToList<Customer>();            //Sort(u => u._Person.Age);
        }
        


        #region Liambda operations
        public int GetSumAllAge()
        {
            //int sum = 0;
            //foreach (Customer c in customers)
            //{
            //    sum += c._Person.Age;
            //}

            //return sum;

            return this.customers.Sum(u => u._Person.Age);

        }
        public int GetMaxAge()
        {
            //int max = 0;
            //foreach (Customer c in customers)
            //{
            //    if(max< c._Person.Age)
            //        max = c._Person.Age;
            //}

            //return max;
            return this.customers.Max(u => u._Person.Age);

        }
        public int GetMinAge()
        {
            //int min = 0;
            //foreach (Customer c in customers)
            //{
            //    if (min > c._Person.Age)
            //        min = c._Person.Age;
            //}

            //return min;
            return this.customers.Min(u => u._Person.Age);

        }
        public double GetAvaregeAge()
        {
            //int avg = 0;
            //foreach (Customer c in customers)
            //{
            //    avg += c._Person.Age;
            //}

            //return avg /= customers.Count;
            return this.customers.Average(u => u._Person.Age);

        }
        #endregion


        #region IEnumerable, IEnumerator 
        public IEnumerable GetCustomers(int max)//foreach (Customer item in cs.GetCustomers(3))
        {
            for (int i = 0; i < max; i++)
            {
                if (i == max)
                {
                    yield break;
                }
                else yield return customers[i];
            }
        }
        public object Current
        {
            get
            {
                return Current;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return this.customers.GetEnumerator();
        }
        public bool MoveNext()
        {
            pos++;
            return (pos < customers.Count);
        }
        public void Reset()
        {
            pos = -1;
        }
        #endregion
    }
}
