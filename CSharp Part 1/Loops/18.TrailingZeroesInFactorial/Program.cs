using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int i=0;
            int numberZeroes = 0;
                int pom=number;
            while (number / 5 != 0)
            {
                number = number / 5;
                i++;
            }
            for (int j = 1; j <= i; j++)
            {
                numberZeroes+=(pom/(int)Math.Pow(5,j));
 
            }
            Console.WriteLine(numberZeroes);

        }
    }

