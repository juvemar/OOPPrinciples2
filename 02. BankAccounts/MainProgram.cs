namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MainProgram
    {
        static void Main()
        {
            IndividualCustomer first = new IndividualCustomer("Petio", CustomerType.Individual);
            CompanyCustomer second = new CompanyCustomer("DMTS", CustomerType.Company);
            IndividualCustomer thirds = new IndividualCustomer("Tanio", CustomerType.Individual);

            MortgageAccount mortgageAcc = new MortgageAccount(first, 1000, 3.44m);
            LoanAccount loanAcc = new LoanAccount(second, 800, 1.2m);
            DepositAccount depositAcc = new DepositAccount(thirds, 900, 5.6m);

            List<Account> list = new List<Account>();
            list.Add(mortgageAcc);
            list.Add(loanAcc);
            list.Add(depositAcc);

            foreach (var cust in list)
            {
                Console.WriteLine("{0} - {1} customer", cust.Client.Name, cust.Client.Type);
                Console.WriteLine("Type account - {0}\nBalance - {1}$\nInterest rate - {2}%", cust.GetType().Name, cust.Balance, cust.InterestRate);
                Console.WriteLine();
            }
        }
    }
}
