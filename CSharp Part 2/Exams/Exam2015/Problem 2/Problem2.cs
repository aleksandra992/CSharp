using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            BigInteger sum = new BigInteger();
            sum = 0;
            long previous = 0;
            long current = int.MaxValue;
            BigInteger currentSum = new BigInteger();
            currentSum = 0;
            for (int i = 1; i < input.Length; i++)
            {
                previous = input[i - 1];
                current = input[i];
                if (previous > current)
                {
                    currentSum = previous - current;
                }
                else
                    currentSum=current - previous;

                
                if (currentSum % 2 != 0)
                {
                    
                    i++;
                    i--;
                }
                if (currentSum % 2 == 0)
                {
                    sum += (BigInteger)currentSum;
                    i ++;
                }
                
                
                if (i >= input.Length)
                {
                    break;
                }
                currentSum = 0;

            }
            Console.WriteLine(sum);

        }
    }
}
