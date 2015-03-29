namespace _1.Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width cannot be less than zero");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be less than zero");
                }
                this.height=value;
            }
        }
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;

        }
        public abstract double CalculateSurface();
    }
}
