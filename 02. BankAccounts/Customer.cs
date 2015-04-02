using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public abstract class Customer
    {
        //fields
        private string name;
        private CustomerType type;

        //constructors
        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
        }

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }
    }
}
