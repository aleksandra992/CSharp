using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public interface IVisitor
    {
        float Visit(Item item);
    }
}
