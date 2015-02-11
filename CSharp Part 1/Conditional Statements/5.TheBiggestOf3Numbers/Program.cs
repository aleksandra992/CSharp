using System;

namespace _5.TheBiggestOf3Numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter c=");
            double c = double.Parse(Console.ReadLine());
            double max=0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine(max);
        }
    }
}
