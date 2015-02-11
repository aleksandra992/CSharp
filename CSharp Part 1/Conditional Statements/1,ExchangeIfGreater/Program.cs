using System;


namespace _1_ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter b=");
            double b = double.Parse(Console.ReadLine());
            double hint;
            if (a > b)
            {
                hint = a;
                a = b;
                b = hint;
 
            }
            Console.WriteLine(a + " " + b);
        }
    }
}
