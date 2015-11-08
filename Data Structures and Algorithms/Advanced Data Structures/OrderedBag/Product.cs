namespace OrderedBag
{
    using System;

    public class Product : IComparable<Product>
    {
        public Product(double price, string name)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}; Price: {this.Price:F2}";
        }
    }
}
