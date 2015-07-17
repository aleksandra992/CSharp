namespace CSharpt1Exam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Maslan
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            long sum = 0;
            BigInteger product = 1;
            long numOfIterations = 0;
            if (number.Length == 1)
            {
                Console.WriteLine(numOfIterations);
                Console.WriteLine(product);
                return;
            }

            string currentNumber = number;
            while (numOfIterations < 10)
            {
                if (currentNumber.Length == 1)
                {
                    Console.WriteLine(numOfIterations);
                    Console.WriteLine(currentNumber);
                    return;
                }

                while (currentNumber.Length != 0)
                {
                    currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                    for (int j = 0; j < currentNumber.Length; j++)
                    {
                        if (j % 2 != 0)
                        {
                            sum += int.Parse(currentNumber[j].ToString());                        
                        }
                    }

                    if (sum != 0)
                    {
                        product *= sum;
                    }

                    if (sum == 0)
                    {
                        product *= 1;
                    }

                    sum = 0;
                }

                currentNumber = product.ToString();
                numOfIterations++;
                product = 1;
            }

            Console.WriteLine(currentNumber);
        }
    }
}