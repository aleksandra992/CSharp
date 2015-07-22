using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class CalculationProblem
    {
       public static char[] FillArrayWithCharSymbols(int numberOfSymbols)
        {
            char[] symbols = new char[23];
            const int asciLetterA = 97;
            for (int i = 0; i < numberOfSymbols; i++)
            {
                symbols[i] = (char)(i + asciLetterA);
            }
            return symbols;

        }
       public static List<ulong> ConvertLettersToNumbersWithBase23(string[] words)
        {
            char[] symbols = FillArrayWithCharSymbols(23);
            List<ulong> lettersAsNumbers = new List<ulong>();
            string word;
            char letter;
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                ulong number = 0;
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    letter = word[j];

                    number += (ulong)Array.IndexOf(symbols, letter) * (ulong)Math.Pow(23, word.Length - 1 - j);
                }
                lettersAsNumbers.Add(number);


            }
            return lettersAsNumbers;
        }
       public static ulong GetDecimalSum(List<ulong> numbers)
        {
            ulong sumInDecimal = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumInDecimal += numbers[i];
            }
            return sumInDecimal;
        }
       public static string GetSystemBaseSum(ulong decimalSum, char[] symbols, ulong systemBase)
        {
            ulong currentDecimalSum = decimalSum;
            string sumInBase = string.Empty;
            if (decimalSum == 0)
            {
                sumInBase = "a";
            }
            ulong remainder = 0;

            while (currentDecimalSum != 0)
            {
                remainder = currentDecimalSum % systemBase;
                sumInBase += symbols[remainder];
                currentDecimalSum /= systemBase;
            }
            char[] currentSumInBaseReversed = sumInBase.ToCharArray();
            Array.Reverse(currentSumInBaseReversed);
            sumInBase = new string(currentSumInBaseReversed);
            return sumInBase;
        }
       public static void Main(string[] args)
        {
            const int systemBase = 23;
            char[] symbols = FillArrayWithCharSymbols(systemBase);
            string[] words = Console.ReadLine().Split(' ');
            List<ulong> lettersAsNumbers = new List<ulong>();

            lettersAsNumbers = ConvertLettersToNumbersWithBase23(words);
            ulong decimalSum = GetDecimalSum(lettersAsNumbers);
            string sumInBase23 = GetSystemBaseSum(decimalSum, symbols, (ulong)systemBase);
            Console.WriteLine("{0} = {1}", sumInBase23, decimalSum);

        }
    }
}
