using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{

    //class Product : IComparable<Product>
    //{

    //    public Product(string name, decimal price, string type)
    //    {
    //        this.Name = name;
    //        this.Price = price;
    //        this.Type = type;
    //    }

    //    public string Name { get; set; }

    //    public decimal Price { get; set; }

    //    public string Type { get; set; }

    //    public int CompareTo(Product other)
    //    {
    //        int result;
    //        result = this.Price.CompareTo(other.Price);
    //        if (result == 0) result = this.Name.CompareTo(other.Name);
    //        if (result == 0) result = this.Type.CompareTo(other.Type);

    //        return result;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("{0}({1})", this.Name, this.Price.ToString("G29"));
    //    }

    //    //public override int GetHashCode()
    //    //{
    //    //    return this.Name.GetHashCode();
    //    //}

    //    //public override bool Equals(object obj)
    //    //{
    //    //    return this.GetHashCode().Equals(obj.GetHashCode());
    //    //}
    //}
}
