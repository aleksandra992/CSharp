using System;


    class Program
    {
        static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            int productOdds = 1, productEvens = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    productEvens *= int.Parse(s[i]);
                }
                else
                    productOdds *= int.Parse(s[i]);

 
            }
            if (productOdds == productEvens)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }

