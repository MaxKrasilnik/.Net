using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryClass_Pr_06
{

    public class Employee
    {
        private string firstName;
        private string lastName;
        private int inn;
        private int age;
        private string address;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int Inn
        {
            get
            {
                return inn;
            }
            set
            {
                inn = value;
            }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public Employee(string FirstName, string LastName, int Inn, int Age, int address)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.inn = Inn;
            this.age = Age;
            this.address = Address;
        }
    }
}
