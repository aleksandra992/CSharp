using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first date");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine("Enter second date");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Distance {0} ", (secondDate - firstDate).TotalDays);
        }
    }
}
