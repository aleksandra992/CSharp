namespace RemoveOddOCcurences
{
    using System;
    using System.Collections.Generic;

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

            Dictionary<int, int> occurences = new Dictionary<int, int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences[number] = 1;
                }
            }

            var evenOccurencesNumbers = new List<int>();
            for (var i = 0; i < numbers.Count; i++)
            {
                var number = numbers[i];
                if (occurences[number] % 2 == 0)
                {
                    evenOccurencesNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", evenOccurencesNumbers));
        }
    }
}
