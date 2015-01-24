using System;


namespace _1.NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
