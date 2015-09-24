using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Rectangle : Shape
    {
        public float Height { get; set; }

        public float Width { get; set; }

        public Rectangle(IInputProvider input)
            : base(input)
        {
            this.Height = input.GetHeight();
            this.Width = input.GetWidth();
        }
        public override float Area()
        {
            return this.Height * this.Width;
        }

        public override float Perimeter()
        {
            return 2 * (this.Width + this.Height);
        }

    }
}
