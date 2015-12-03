using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            int Sum = 0;
            for (var i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
                Sum += number;
            }

            BigInteger[] combinations = new BigInteger[Sum + 1];
            combinations[0] = 1;
            int maxSum = 0;
            for (var i = 0; i < n; i++)
            {
                int number = numbers[i];
                for (var j = maxSum; j >= 0; j--)
                {
                    combinations[j + number] += combinations[j];
                    if (j + number > maxSum)
                    {
                        maxSum = j + number;
                    }
                }
            }

            BigInteger result = 0;
            for (var i = k; i < combinations.Length; i++)
            {
                result += combinations[i];
            }

            Console.WriteLine(result);
        }
    }
}
