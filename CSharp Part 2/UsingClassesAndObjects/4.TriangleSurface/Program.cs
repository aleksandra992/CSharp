using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Choose:\n1-Side and altitude\n2-Three sides\n3-Two sides and angled between them");
            int choise = int.Parse(Console.ReadLine());
            decimal result = 0;
            switch (choise)
            {
                case 1:
                    {
                        Console.Write("Enter side=");
                        decimal side = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter altitude=");
                        decimal altitude = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("The surface is {0}", side * altitude / 2);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter first side=");
                        decimal first = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter second side=");
                        decimal second = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter third side=");
                        decimal third = decimal.Parse(Console.ReadLine());
                       
                        decimal p = (first + second + third) / 2;
                        decimal area =(decimal) Math.Sqrt((double)(p * (p - first) * (p - second) * (p - third)));
                        Console.WriteLine("The area is {0}", area);
                        break;
                    }
                case 3:
                    {
                        Console.Write("Enter side1=");
                        decimal side1 = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter side2=");
                        decimal side2 = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter angle=");
                        decimal angle = decimal.Parse(Console.ReadLine());
                        angle = angle * (decimal)Math.PI / 180;
                        Console.WriteLine("The surface is {0}", ((double)(side1 * side2)) * (Math.Sin((double)angle) / 2));


                        break;
                    }
            }
        }
    }
}
