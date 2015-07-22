using System;
using System.Text;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalcSurface();

        public abstract double CalcPerimeter();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("I am {0}", this.GetType().Name).AppendLine();
            result.AppendFormat("My area is {0:f2}. My perimeter is {1:f2}", this.CalcSurface(), this.CalcPerimeter());

            return result.ToString();
        }
    }
}
