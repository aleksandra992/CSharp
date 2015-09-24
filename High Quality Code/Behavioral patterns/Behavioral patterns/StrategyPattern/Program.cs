using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IInputProvider input = new ConsoleInputProvider();
            IShape rectangle = new Rectangle(input);
            IDrawer drawer = new ConsoleDrawer();
            drawer.Draw(rectangle);

        }
    }
}
