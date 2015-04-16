namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ShoppingCart:IShoppingCart
    {
        private ICollection<IProduct> products;
        public ShoppingCart()
        {
            products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if (this.products.FirstOrDefault(p => p.Name == product.Name) == null)
                return false;
            return true;
        }

        public decimal TotalPrice()
        {
            return this.products.Sum(p => p.Price);

        }
    }
}
