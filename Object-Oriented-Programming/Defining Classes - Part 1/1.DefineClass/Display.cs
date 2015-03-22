using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class Display
    {
        private double size;
        private int numOfColors;
        public double Size
        {
            get
            {
                return this.size;
            }
            set {
                this.size = value;
            }
        }
        public Display( double size)
        {
            this.Size = size;
        }
        public Display(double size,int numColors):this(size)
        {
            this.numOfColors = numColors;

        }
        public override string ToString()
        {
            return
           "The size of the display is "+ this.size+
           "\nThe number of colors are "+numOfColors;
        }
    }
}
