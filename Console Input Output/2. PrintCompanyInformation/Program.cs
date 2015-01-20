using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name:");
            string companyName=Console.ReadLine();
            Console.WriteLine("Company address");
            string companyaddress=Console.ReadLine();
            Console.WriteLine("Phone number");
            string phoneNumber=Console.ReadLine();
            Console.WriteLine("Fax number");
            string faxNumber=Console.ReadLine();

            Console.WriteLine("Web site:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Manager first name");
            string managerFirstName = Console.ReadLine();
            Console.WriteLine("Manager last name");
            string managerLastName = Console.ReadLine();
            Console.WriteLine("Manager age");
            string managerAge = Console.ReadLine();
            Console.WriteLine("Manager phone");
            string managerPhone = Console.ReadLine();

            Console.Write(companyName+"\nAddress:"+companyaddress+"\nTel."+ phoneNumber+"\nFax:("+faxNumber+")\nWeb site:"+webSite+"\nManager:"+managerFirstName+" "+managerLastName+" (age:"+managerAge+", tel."+managerPhone+")");


            
        }
    }
}
