using System;
using System.Numerics;
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n) /Factorial(k));
            BigInteger nfac = 1;
            BigInteger kfac = 1;

        /* Second decision  
         * for (int i = 1; i <= n; i++)
            {
                nfac *= (uint)i;
                if (i <= k)
                {

                    kfac *= (uint)i;
                }
            }
            Console.WriteLine(nfac / kfac);
         * */
        }
        static BigInteger Factorial(uint n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else return n * Factorial(n - 1);
        }
    }

