using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public interface IShape:IContentProvider
    {
        float Area();

        float Perimeter();
    }
}
