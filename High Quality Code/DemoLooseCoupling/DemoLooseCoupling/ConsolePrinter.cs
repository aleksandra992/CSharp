using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class ConsolePrinter:IPrinter
    {
        public void Print(IContentProvider provider)
        {
            Console.WriteLine(provider.ProvideContent());
        }
    }
}
