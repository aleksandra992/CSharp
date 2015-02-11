using System;

namespace _8.Numbers_from1ToN
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter number n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
