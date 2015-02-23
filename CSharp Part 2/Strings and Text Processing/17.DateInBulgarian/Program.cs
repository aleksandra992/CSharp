using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17.DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the date in format day.month.year hour:minute:second");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            CultureInfo provider=CultureInfo.GetCultureInfo("BG-bg");
          
            DateTime date = new DateTime();
            try
            {
                date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy hh:mm:ss", provider);
                date = date.AddHours(6);
                date = date.AddMinutes(30);
                
                Console.WriteLine(date.ToString("dd.MM.yyyy hh:mm:ss dddd",provider));
            }
            catch (Exception e)
            {
                Console.WriteLine("The format must be in the specified format");
            }

          
           
        }
    }
}
