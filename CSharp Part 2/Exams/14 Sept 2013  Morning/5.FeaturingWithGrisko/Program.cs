using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FeaturingWithGrisko
{
    class Program
    {
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
           char[] word = input.ToCharArray();
           Array.Sort(word);
           int counter = 0;
           if (isValid(word))
           {
               counter++;
           }
         
            while (NextPermutation(word))
            {
                if (isValid(word))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }


        private static bool NextPermutation(char[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap i-th and j-th elements
                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }

            // No more permutations
            return false;
        }
        public static bool isValid(char[] word)
        {
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
