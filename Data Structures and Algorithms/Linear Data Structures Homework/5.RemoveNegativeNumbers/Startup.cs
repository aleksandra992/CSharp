namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Startup
    {
        public static void Main()
        {
            string input;

            var numbers = new List<int>();
            Console.WriteLine("Enter numbers each on a separate line");
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                numbers.Add(int.Parse(input));
            }

            var positiveNumbers = numbers.Where(x => x > 0);
            Console.WriteLine("The positive numbers are {0} ", string.Join(",", positiveNumbers));
            

        }
    }
}
