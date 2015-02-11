using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("enter d=");
            double d = double.Parse(Console.ReadLine());
            Console.Write("enter e=");
            double e = double.Parse(Console.ReadLine());
            double max=0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if(e>max)
            {
                max = e;
            }
            Console.WriteLine(max);

        }
    }
}
