namespace Facade
{
    using System;
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
