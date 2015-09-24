using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ConsoleInputProvider:IInputProvider
    {
        public int GetWidth()
        {
            Console.WriteLine("Enter the width of the rectangle");
            return int.Parse(Console.ReadLine());
        }

        public int GetHeight()
        {
            Console.WriteLine("Enter the height of the rectangle");
            return int.Parse(Console.ReadLine());
        }
    }
}
