using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter x");
           double x =double.Parse( Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = double.Parse(Console.ReadLine());

            if (Math.Pow(x,2)+Math.Pow(y,2)<=2*2)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }
    }
}
