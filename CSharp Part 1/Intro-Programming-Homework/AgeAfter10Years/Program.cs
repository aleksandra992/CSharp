using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime birth = DateTime.Parse(Console.ReadLine());
           
            DateTime today = DateTime.Today;  
            TimeSpan age = today - birth;        
            double ageInDays = age.TotalDays;    
            double daysInYear = 365.2425;        
            double ageInYears =ageInDays / daysInYear;
            Console.WriteLine("You are"+ageInYears+"years old");
            Console.WriteLine("After 10 years you will be" + (ageInYears + 10) + " years old");
            Console.ReadKey();

        }
        
    }
}
