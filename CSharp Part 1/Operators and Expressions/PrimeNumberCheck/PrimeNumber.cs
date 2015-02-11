using System;

namespace PrimeNumberCheck
{
    class PrimeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());

            if (number == 0 || number == 1)
            {
                Console.WriteLine("false");
                return;
            }
            else
                for(int i=2;i<=Math.Sqrt(number);i++)
                {
                    if(number%i==0)
                    {
                        Console.WriteLine("false");
                        return;
                    }

                }
            Console.WriteLine("true");
        }
    }
}
