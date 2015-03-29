namespace BankAccounts.Accounts
{
    using System;
    using BankAccounts.Customers;
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override decimal InterestAmount(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return 0.5m * base.InterestAmount(months);
                }
                else
                {
                    return 0.5m * base.InterestAmount(12) + base.InterestAmount(months - 12);
                }


            }
            else
                if(this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return base.InterestAmount(0);
                }
                else
                {
                    return  base.InterestAmount(months - 6);
                }
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Format("Mortgage: {0} {1}", this.Customer.Name, this.Balance);
        }
    }
}
