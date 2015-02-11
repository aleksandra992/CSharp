using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
       
        static void Main(string[] args)
        {
            string name = "Aleksandra";
            string surname = "Stoycheva";
            decimal availableAmountMoney = 12345.12345688M;
            string bankName = "Fibank";
            string IBAN = "123456789";
            string firstCreditCardNumber = "789456123";
            string secondCreditCardNumber = "789456123";
            string thirdCreditCardNumber = "789456123";

           Console.WriteLine("Name:{0} Surname:{1} AvailableAmountOfMoney:{2} BankName:{3} IBAN:{4} first credit number:{5} second credit number:{6} third credit number:{7} ", name, surname, availableAmountMoney, bankName, IBAN, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        
        }
    }
}
