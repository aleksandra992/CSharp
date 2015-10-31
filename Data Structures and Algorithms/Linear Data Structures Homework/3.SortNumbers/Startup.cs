namespace SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string input;
            var positiveNumbers = new List<int>();
            Console.WriteLine("Enter numbers each on a separate line");
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                positiveNumbers.Add(int.Parse(input));
            }

            Console.WriteLine("Sorted list:");
            List<int> sortedNumbers = positiveNumbers.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}
