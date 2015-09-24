using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Shape:IShape,IContentProvider
    {
        IInputProvider widthAndHeightInput;
        
        public Shape(IInputProvider input)
        {
            widthAndHeightInput = input;
        }


        public abstract float Area();

        public abstract float Perimeter();


        public string GetContent()
        {
            return string.Format("The aresa of the rectangle is {0} ", this.Area());
        }
    }
}
