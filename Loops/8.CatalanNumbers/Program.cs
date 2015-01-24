using System;
using System.Numerics;

    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
           
            uint doubleN = 2 * n;
            BigInteger doubleNFac = 1,nFac=1;

            for (int i = 1; i <=2*n; i++)
            {
                doubleNFac *= i;
                if (i <= n)
                {
                    nFac *= i;
                }
               

            }
            Console.WriteLine(doubleNFac/((n+1)*nFac*nFac));
        }
    }

