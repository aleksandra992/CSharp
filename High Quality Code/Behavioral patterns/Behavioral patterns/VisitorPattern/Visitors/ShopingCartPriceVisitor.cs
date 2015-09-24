using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ShopingCartPriceVisitor : IVisitor
    {
        private float itemPrice;

        public float Visit(Item item)
        {
            if (item.Weight < 100)
            {
                itemPrice = item.Weight * 0.2f;
            }
            else
                itemPrice = item.Weight * 0.1f;

            return itemPrice;
        }
    }
}
