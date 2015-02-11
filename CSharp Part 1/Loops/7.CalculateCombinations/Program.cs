using System;
using System.Numerics;



    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            uint p = n - k;
            BigInteger nfac=1, kfac=1, pfac = 1;

            for (int i = 1; i <=n; i++)
            {
                nfac *= i;
                if (i <= k)
                {
                    kfac *= i;
                }
                if (i <= p)
                {
                    pfac *= i;
                }

            }
            Console.WriteLine(nfac / (kfac * pfac));
        }
    }

