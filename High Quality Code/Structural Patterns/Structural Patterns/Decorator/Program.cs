namespace Decorator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Shape circe=new Circle();

            Shape blueCircle= new BlueShapeDecorator(new Circle());

            Shape blueRectangle=new BlueShapeDecorator(new Rectangle());

            Console.WriteLine("----------------------");
            Console.WriteLine("Normal circle");
            circe.Draw();
            Console.WriteLine("----------------------");

            Console.WriteLine("Circle with blue border");
            blueCircle.Draw();
            Console.WriteLine("----------------------");

            Console.WriteLine("Rectangle with blue border");
            blueRectangle.Draw();
            Console.WriteLine("----------------------");



        }
    }
}
