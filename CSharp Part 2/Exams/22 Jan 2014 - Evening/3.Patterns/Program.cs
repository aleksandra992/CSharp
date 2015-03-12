using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];
            int[] row = new int[n];
            bool ifExist = false;
            BigInteger sumOfDiagonal = new BigInteger();
            sumOfDiagonal = 0;
            BigInteger sumOfpattern = new BigInteger();
            BigInteger maxSumOfPattern = new BigInteger();
            sumOfpattern = 0;
            maxSumOfPattern = -15032385536;
            for (int i = 0; i < n; i++)
            {
                row = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }

            }
           
            for (int i = 0; i <= n - 3; i++)
            {
                for (int j = 0; j <= n - 5; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] - 1
                    && matrix[i, j + 1] == matrix[i, j + 2] - 1
                    && matrix[i, j + 2] == matrix[i + 1, j + 2] - 1
                    && matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1
                    && matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1
                    && matrix[i + 2, j + 3] == matrix[i + 2, j + 4] - 1)
                    {
                        ifExist = true;
                        sumOfpattern = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j + 2]
                                     + matrix[i + 2, j + 2] + matrix[i + 2, j + 3]  + matrix[i + 2, j + 4];
                        if (sumOfpattern > maxSumOfPattern)
                        {
                            maxSumOfPattern = sumOfpattern;
                        }
                    }

                }
            }
            if (ifExist)
            {
                Console.WriteLine("YES {0}", maxSumOfPattern);
                return;
            }
            if (!ifExist)
            {
                sumOfDiagonal = SumOfDiagonal(matrix,n);
                Console.WriteLine("NO {0}", sumOfDiagonal);
            }


        }
        static BigInteger SumOfDiagonal(long[,] matrix, int n)
        {
            BigInteger sumOfDiagonal = new BigInteger();
            for (int i = 0; i < n; i++)
            {

                sumOfDiagonal += matrix[i, i];
            }
                return sumOfDiagonal;
        }
     
    }
}
