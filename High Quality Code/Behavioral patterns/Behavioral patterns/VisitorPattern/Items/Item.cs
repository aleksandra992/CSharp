using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class Item
    {

        public Item(float weight)
        {
            this.Weight = weight;
        }

        public float Weight { get; set; }


        public float Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
