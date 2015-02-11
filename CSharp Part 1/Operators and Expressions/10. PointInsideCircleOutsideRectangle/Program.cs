using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideCircleOutsideRectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = double.Parse(Console.ReadLine());
            bool InsideCircle=false;
            bool InsideRectangle=false;
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)///formula for distance between two points for the circle
            {
                InsideCircle = true;
            }
            if ((x >= -1 && x <= 5) && (y >= -1 && y <= 1))// for the rectangle checking if the point is inside with cordinate x and cordinate y
            {
                InsideRectangle = true;
            }
            if(InsideCircle && !InsideRectangle)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");


                       

          
        }
    }
}
