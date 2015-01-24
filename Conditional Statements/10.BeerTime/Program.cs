using System;
using System.Globalization;

namespace _10.BeerTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a time  in format “hh:mm tt in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)");
            try
            {
                string s=Console.ReadLine();
                DateTime date = DateTime.ParseExact(s, "hh:mm tt",CultureInfo.InvariantCulture);

                int hour = date.Hour;
                int minutes = date.Minute;

                string designator = date.ToString("tt", CultureInfo.InvariantCulture).ToLower();
                if ((hour >= 13 && hour < 24 && designator == "pm") || (hour >= 0 && hour <= 3 && designator == "am"))
                {
                    Console.WriteLine("Beer time");
                }
                else
                    Console.WriteLine("non-beer time");

            }
            catch
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
