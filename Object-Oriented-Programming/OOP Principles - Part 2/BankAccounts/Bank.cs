namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using BankAccounts.Accounts;
    using BankAccounts.Customers;
    public class Bank
    {
    
        public static void CreateBank()
        {
            List<Account> accounts = new List<Account>();
            Customer customerPesho=new Individual("Pesho");
        
            Customer customerGosho = new Individual("Gosho");
            Customer companyTelerik = new Company("Telerik");
            DepositAccount d = new DepositAccount(customerPesho, 4544.433m, 30m);


            accounts.Add(d);
            accounts.Add(new LoanAccount(customerGosho, 150.3m, 3m));
            accounts.Add(new MortgageAccount(companyTelerik, 5000m, 2m));
            accounts.Add(new LoanAccount(companyTelerik, 120m, 2m));
            Console.WriteLine("Accounts:");
            foreach (var account in accounts)
	{
                Console.WriteLine(account);
		 
	}
            
            PrintInterestAmount(3,accounts);
            PrintInterestAmount(6,accounts);
            PrintInterestAmount(9,accounts);
        }

       private static void PrintInterestAmount(int months,List<Account> accounts)
       {
            Console.WriteLine("The interest amount for {0} months for all accounts:",months);
            foreach (var account in accounts)
            {
              
                Console.WriteLine(" Interest amount: {0}",account.InterestAmount(months));     
            }
       }


       
    }
}
