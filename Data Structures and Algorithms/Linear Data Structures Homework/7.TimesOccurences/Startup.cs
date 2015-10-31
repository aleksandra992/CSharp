namespace TimesOccurences
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
                if (occurences.ContainsKey(numbers[i]))
                {
                    occurences[numbers[i]]++;
                }
                else
                {
                    occurences[numbers[i]] = 1;
                }
            }

            foreach (var item in occurences)
            {
                Console.WriteLine("Number {0}--->{1}-times", item.Key, item.Value);
            }
        }
    }
}
