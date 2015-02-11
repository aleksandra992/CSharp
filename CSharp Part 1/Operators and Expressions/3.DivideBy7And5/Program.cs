using System;


namespace _3.DivideBy7And5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 7 == 0) && (n % 5 == 0));
        }
    }
}
