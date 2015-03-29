namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;
    public abstract class Account:IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        public Account(Customer customer, decimal balance, decimal interestRate)
        {

            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;

        }
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The customer cannot be null");
                }
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
           protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance cannot be lexx than zero");
                }
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
                this.interestRate = value;
            }
        }

        public virtual decimal InterestAmount(int months)
        {
            return 100*( this.interestRate/100 * months);
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }


    }
}
