using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class IndividualCustomer : Customer
    {
        //constructors
        public IndividualCustomer(string name, CustomerType type)
            : base(name, type)
        {

        }
    }
}
