namespace _1.Shapes
{
    using System;
    using System.Collections.Generic;
    public class StartingPoint
    {
        public static void Main()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Square(5),
            new Rectangle(5,2),
            new Triangle(5,5)
            };
            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType().Name+" "+item.CalculateSurface());
            }

        }
    }
}
