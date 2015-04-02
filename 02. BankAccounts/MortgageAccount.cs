namespace _02.BankAccounts
{
    using System;
    class MortgageAccount : Account, IDepositable
    {
        //constructors
        public MortgageAccount(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {

        }

        //methods
        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }

        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            if (this.Client.Type == CustomerType.Company)
            {
                if (periodInMonths < 13)
                {
                    return (periodInMonths * this.InterestRate) / 2;
                }
                else
                {
                    decimal firstTwelveMonths = (12 * this.InterestRate) / 2;
                    return firstTwelveMonths + (periodInMonths - 12) * this.InterestRate;
                }
            }
            else
            {
                if (periodInMonths < 7)
                {
                    return 0;
                }
                else
                {
                    return (periodInMonths - 3) * this.InterestRate;
                }
            }
        }
    }
}
