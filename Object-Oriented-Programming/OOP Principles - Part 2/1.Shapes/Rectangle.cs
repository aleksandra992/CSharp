namespace _1.Shapes
{
    using System;
    public class Rectangle:Shape
    {
        public Rectangle(double height,double width):base(width,height)
        {

        }


        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
