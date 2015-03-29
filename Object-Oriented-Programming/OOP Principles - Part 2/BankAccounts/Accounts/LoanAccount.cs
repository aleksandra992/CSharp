


namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;
    public class LoanAccount : Account
    {

        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }
        public override decimal InterestAmount(int months)
        {
            if (this.Customer is Individual)
            {
                if (months <= 3)
                {
                    months = 0;
                }
                else
                    months = months - 3;
          }
            else
                if (this.Customer is Company)
                {
                    if (months <= 2)
                    {
                        months = 0;
                    }
                    else
                        months = months - 2;
               }
            return base.InterestAmount(months);
        }
        public override string ToString()
        {
            return string.Format("LOAN: {0} {1}", this.Customer.Name, this.Balance);
        }

    }
}
