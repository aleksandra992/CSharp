namespace SequenceOfPositiveNumbers
{
    using System;
    using System.Collections.Generic;

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

            Console.WriteLine("The sum of the numbers is:{0}", CalculateSum(positiveNumbers));
            Console.WriteLine("The avergae of the numbers is {0}", CalculateAverage(positiveNumbers));
        }

        public static int CalculateSum(List<int> numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static float CalculateAverage(List<int> numbers)
        {
            float average = 0;
            average = CalculateSum(numbers) / (float)numbers.Count;
            return average;
        }
    }
}
