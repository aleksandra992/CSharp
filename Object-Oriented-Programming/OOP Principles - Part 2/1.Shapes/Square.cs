namespace _1.Shapes
{
    using System;
    public class Square:Shape
    {
        public Square(double side):base(side,side)
        {


        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
