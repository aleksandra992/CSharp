

namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;
    public class DepositAccount : Account,IWithDrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

      
        public void WithDrawMoney(decimal money)
        {
            
            this.Balance -= money;
            
        }
        public override decimal InterestAmount(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else
                return base.InterestAmount(months);
        }
        public override string ToString()
        {
            return string.Format("Deposit: {0} {1}", this.Customer.Name, this.Balance);
        }
    }
}
