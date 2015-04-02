namespace _02.BankAccounts
{
    using System;
    public abstract class Account
    {
        //fields
        private Customer client;
        private decimal balance;
        private decimal interestRate;


        //constructor
        public Account(Customer client, decimal balance, decimal interestRate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        //properties
        public Customer Client
        {
            get
            {
                return this.client;
            }
            private set
            {
                this.client = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate should be a positive value!");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount(int periodInMonths)
        {
            return periodInMonths * this.InterestRate;
        }
    }
}
