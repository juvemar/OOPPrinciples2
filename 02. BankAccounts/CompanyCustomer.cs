using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class CompanyCustomer : Customer
    {
        //constructors
        public CompanyCustomer(string name, CustomerType type)
            : base(name, type)
        {

        }
    }
}
