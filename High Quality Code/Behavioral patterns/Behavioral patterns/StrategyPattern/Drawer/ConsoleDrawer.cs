using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ConsoleDrawer : IDrawer
    {
        public void Draw(IContentProvider provider)
        {
            Console.WriteLine(provider.GetContent());
        }
    }
}
