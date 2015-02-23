using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.DatesFromTextInCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string text = Console.ReadLine();
            CultureInfo provider=CultureInfo.GetCultureInfo("en-CA");
            foreach (var item in Regex.Matches(text, @"\d\d\.\d\d\.\d\d\d\d"))
            {
                DateTime date = DateTime.ParseExact(item.ToString(),"dd.MM.yyyy",provider);
                Console.WriteLine("{0}",date.ToString(provider));

            }
        }
    }
}
