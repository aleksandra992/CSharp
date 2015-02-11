using System;
using System.Globalization;
using System.Threading;


namespace _3.CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter the radius r=");
            double radius = double.Parse(Console.ReadLine());
            double area=Math.Pow(radius,2)*Math.PI;
            double perimeter=Math.PI*2*radius;
            Console.WriteLine("The perimeter is {0:0.00} and the area is {1:0.00}", perimeter,area);
        }
    }
}
