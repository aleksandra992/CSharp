using System;
using System.Collections.Generic;
using System.IO;

namespace WordsCount
{
    public class Startup
    {
        public static void Main()
        {
            var wordOccurences = new Dictionary<string, int>();

            var words = File.ReadAllText("../../words.txt").Split(new char[] { ',', ' ', '?', '!', '.', '–', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                var wordToLower = word.ToLower();
                if (!wordOccurences.ContainsKey(wordToLower))
                {
                    wordOccurences[wordToLower] = 1;
                }
                else
                {
                    wordOccurences[wordToLower]++;
                }
            }

            //This is to keep the values sorted for not to spend time to sort them each time
            var sortedDictionary = new SortedDictionary<int, List<string>>();

            foreach (var word in wordOccurences)
            {
                if (!sortedDictionary.ContainsKey(word.Value))
                {
                    sortedDictionary[word.Value] = new List<string>();
                }

                sortedDictionary[word.Value].Add(word.Key);
            }

            foreach (var pair in sortedDictionary)
            {
                foreach (var word in pair.Value)
                {
                    Console.WriteLine("{0}->{1}", word, pair.Key);
                }
            }



        }
    }
}
