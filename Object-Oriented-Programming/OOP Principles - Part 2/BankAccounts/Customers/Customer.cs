namespace BankAccounts.Customers
{
    using System;
    public abstract class Customer 
    {
        private string name;


        public Customer(string name)
        {
            this.Name = name;

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty or null");
                }
                this.name = value;
            }
        }
    }
}
