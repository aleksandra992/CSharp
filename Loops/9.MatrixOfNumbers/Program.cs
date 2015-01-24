using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <=i+n-1; j++)
                {
                    Console.Write(j+" ");
                }
                Console.Write("\n");
            }
        }
    }

