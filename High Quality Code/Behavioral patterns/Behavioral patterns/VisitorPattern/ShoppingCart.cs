using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ShoppingCart
    {
        private readonly List<Item> items = new List<Item>();

        public void Add(Item item)
        {
            this.items.Add(item);
        }

        public void Remove(Item item)
        {
            this.items.Remove(item);
        }

        public float CalculateTotal(IVisitor visitor)
        {
            float total = 0;
            foreach (var item in this.items)
            {
                total += item.Accept(visitor);
            }

            return total;
        }

    }
}
