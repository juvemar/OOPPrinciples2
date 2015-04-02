namespace _02.BankAccounts
{
    using System;
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        //constructors
        public DepositAccount(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {

        }

        //methods
        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                throw new ArgumentOutOfRangeException("Interest amount cannot be calculated with positive balance less than 1000!");
            }
            return base.CalculateInterestAmount(periodInMonths);
        }

        void IWithdrawable.WithdrawMoney(decimal sum)
        {
            this.Balance -= sum;
        }

        public void DepositMoney(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
