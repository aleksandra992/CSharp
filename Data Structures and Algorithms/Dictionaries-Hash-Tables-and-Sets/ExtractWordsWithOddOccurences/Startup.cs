using System;
using System.Collections.Generic;

namespace ExtractWordsOnOddPositions
{
    public class Startup
    {
        public static void Main()
        {
            var wordsOccurences = new Dictionary<string, int>();
            var words = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            foreach (var word in words)
            {
                if (!wordsOccurences.ContainsKey(word))
                {
                    wordsOccurences[word] = 1;
                }
                else
                {
                    wordsOccurences[word]++;
                }
            }

            foreach (var pair in wordsOccurences)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.WriteLine(pair.Key);
                }
            }
        }
    }
}
