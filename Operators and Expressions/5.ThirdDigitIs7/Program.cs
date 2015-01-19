using System;


namespace _5.ThirdDigitIs7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter integer number");
            int k = int.Parse(Console.ReadLine());
            k %= 1000;
            k /= 100;
            Console.WriteLine(k == 7);
        }
    }
}
