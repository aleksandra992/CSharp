using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ShapeMakerFacade
    {
        private readonly IShape circle;
        private readonly IShape rectangle;

        public ShapeMakerFacade()
        {
            circle=new Circle();
            rectangle=new Rectangle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
