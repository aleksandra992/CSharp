using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ShopingCartWeightVisitor : IVisitor
    {
        float totalWeightForCart;

        public float Visit(Item item)
        {
            totalWeightForCart = item.Weight;
            return totalWeightForCart;
        }
    }
}
