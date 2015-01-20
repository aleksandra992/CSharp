using System;
using System.Globalization;
using System.Threading;


namespace _6.QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter c=");
            double c = double.Parse(Console.ReadLine());
            double x1 = 0, x2 = 0, x12 = 0;
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("X1={0};X2={1}", x1, x2);
            }
            else if (D == 0)
            {
                x12 = -b / (2 * a);
                Console.WriteLine("X1=X2={0}", x12);

            }
            else
                if (D < 0)
                {
                    Console.WriteLine("no real roots");
                }
        }
    }
}
