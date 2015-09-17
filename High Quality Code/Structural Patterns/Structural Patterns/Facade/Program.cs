using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMakerFacade facade=new ShapeMakerFacade();
            Console.WriteLine("Circle");
            facade.DrawCircle();
            Console.WriteLine("---------------  ");
            Console.WriteLine("Rectangle");
            facade.DrawRectangle();

        }
    }
}
