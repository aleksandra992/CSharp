using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The height must be pozitive number");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The width must be pozitive number");
                }

                this.width = value;
            }
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }
    }
}
