using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class EvenDifferences
    {
        public static BigInteger GetAbsoluteDifference(long firstNumber,long secondNumber)
        {
            BigInteger absoluteDifference = 0;

            if (firstNumber > secondNumber)
            {
                absoluteDifference = firstNumber - secondNumber;
            }
            else
            {
                absoluteDifference = secondNumber - firstNumber;
            }

            return absoluteDifference;

        }
 
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            BigInteger sumOfAllEvenDifferences = new BigInteger();
            sumOfAllEvenDifferences = 0;
            long previous = 0;
            long current = 0;
            BigInteger currentSum = new BigInteger();
            currentSum = 0;
            for (int i = 1; i < input.Length; i++)
            {
                previous = input[i - 1];
                current = input[i];
                currentSum = GetAbsoluteDifference(previous, current);

                if (currentSum % 2 == 0)
                {
                    sumOfAllEvenDifferences += (BigInteger)currentSum;
                    i++;
                }

                if (i >= input.Length)
                {
                    break;
                }
                currentSum = 0;

            }

            Console.WriteLine(sumOfAllEvenDifferences);
        }
    }
}
