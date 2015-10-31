namespace LongestSubsequence
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

            int currentSequenceNumber = positiveNumbers[0];
            int currentSequence = 1;
            int maxLongestSequence = 0;
            int maxSequenceNumber = positiveNumbers[0];
            for (var i = 1; i < positiveNumbers.Count; i++)
            {
                if (currentSequenceNumber == positiveNumbers[i])
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxLongestSequence)
                    {
                        maxLongestSequence = currentSequence;
                        maxSequenceNumber = currentSequenceNumber;
                    }

                    currentSequence = 1;
                    currentSequenceNumber = positiveNumbers[i];
                }
            }

            if (currentSequence > maxLongestSequence)
            {
                maxLongestSequence = currentSequence;
                maxSequenceNumber = currentSequenceNumber;
            }

            var maxSequence = Enumerable.Repeat(maxSequenceNumber, maxLongestSequence);
            Console.WriteLine("The longest equal subsequence is");
            Console.WriteLine(string.Join(" ", maxSequence));
        }
    }
}
