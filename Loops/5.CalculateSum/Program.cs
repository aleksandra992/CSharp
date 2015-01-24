using System;




    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            float sum=1;
            int fac = 0;
            for(int i=1;i<=n;i++)
            {
                fac=Factorial(i);
                sum +=( fac /((float)Math.Pow(x,i)));
            }
            Console.WriteLine("{0:F5}",sum);
        }

       static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }

