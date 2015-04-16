namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Cosmetics.Contracts;
    using System.Text;
    using Common;

    public class Category : ICategory
    {
        private string name;
        private const int minLenghtName = 2;
        private const int maxLenghtName = 15;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {

                Validator.CheckIfStringIsNullOrEmpty(value, "Category name cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value, Category.maxLenghtName, Category.minLenghtName, string.Format("Category name must be between {0} and {1} symbols long!", Category.minLenghtName, Category.maxLenghtName));
                //my own validation for min and max
                //Validate.Validation(value, minLenghtName, maxLenghtName,"Category name");
                this.name = value;
            }
        }


        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
            this.products = this.products.OrderBy(p => p.Brand).ThenByDescending(c => c.Price).ToList();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            //check if the same reference exist
            if (this.products.Contains(cosmetics))
            {
                this.products.Remove(cosmetics);

            }

                //check with name
            //if (this.products.FirstOrDefault(p => p.Name == cosmetics.Name) == null)
            //{
            //    this.products.Remove(cosmetics);
            //}
            else
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
        }

        public string Print()
        {
            StringBuilder categoryString = new StringBuilder();
            categoryString.Append(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products"));
            foreach (var product in this.products)
            {
                categoryString.Append("\n" + product.Print());

            }
            return categoryString.ToString();
        }
    }
}
