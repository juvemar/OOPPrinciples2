namespace _02.BankAccounts
{
    using System;
    class LoanAccount : Account, IDepositable
    {
        //constructors
        public LoanAccount(Customer client, decimal balance, decimal interestRate)
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
                if (periodInMonths < 3)
                {
                    throw new ArgumentOutOfRangeException("This period is too short! The first 2 months have no interest!");
                }
                return (periodInMonths-2)*this.InterestRate;
            }
            else
            {
                if (periodInMonths < 4)
                {
                    throw new ArgumentOutOfRangeException("This period is too short! The first 3 months have no interest!");
                }
                return (periodInMonths - 3) * this.InterestRate;
            }
        }
    }
}
