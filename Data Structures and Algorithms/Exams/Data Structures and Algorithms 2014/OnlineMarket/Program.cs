using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket
{
    using Wintellect.PowerCollections;


    class Product : IComparable<Product>
    {

        public Product(string name, decimal price, string type)
        {
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Type { get; set; }

        public int CompareTo(Product other)
        {
            int result;
            result = this.Price.CompareTo(other.Price);
            if (result == 0) result = this.Name.CompareTo(other.Name);
            if (result == 0) result = this.Type.CompareTo(other.Type);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price.ToString("G29"));
        }

        //public override int GetHashCode()
        //{
        //    return this.Name.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    return this.GetHashCode().Equals(obj.GetHashCode());
        //}
    }


    class Program
    {

        public static OrderedMultiDictionary<decimal, Product>.View GetFirstProductsFromToRange(decimal from, decimal to, OrderedMultiDictionary<decimal, Product> articles)
        {
            return
                articles
                .Range(from, true, to, true);
        }

        public static OrderedMultiDictionary<decimal, Product>.View GetFirstProductsFromRange(decimal from, OrderedMultiDictionary<decimal, Product> articles)
        {
            return
                articles
                .RangeFrom(from, true);
        }

        public static OrderedMultiDictionary<decimal, Product>.View GetFirstProductsToRange(decimal to, OrderedMultiDictionary<decimal, Product> articles)
        {
            return
                articles
                .RangeTo(to, true);
        }
        static void Main(string[] args)
        {

            Dictionary<string, OrderedSet<Product>> productsByType = new Dictionary<string, OrderedSet<Product>>();
            OrderedMultiDictionary<decimal, Product> productsByPrice = new OrderedMultiDictionary<decimal, Product>(true);
            HashSet<string> names = new HashSet<string>();
            var result = new StringBuilder();
            var input = Console.ReadLine();
            while (input != "end")
            {
                var commands = input.Split(' ');

                switch (commands[0])
                {
                    case "add":
                        {
                            var name = commands[1];
                            var price = decimal.Parse(commands[2]);
                            var type = commands[3];
                            var product = new Product(name, price, type);

                            if (!productsByType.ContainsKey(type))
                            {
                                productsByType[type] = new OrderedSet<Product>();
                            }

                            if (names.Contains(name))
                            {
                                result.AppendLine(
                                    string.Format("Error: Product {0} already exists", name));
                                break;
                            }
                            else
                            {
                                names.Add(name);
                                productsByType[type].Add(product);
                                productsByPrice[price].Add(product);
                            }

                            result.AppendLine(string.Format("Ok: Product {0} added successfully", name));

                            break;
                        }
                    case "filter":
                        {
                            var filterBy = commands[2];
                            switch (commands[2])
                            {
                                case "type":
                                    {
                                        var type = commands[3];
                                        var subResult = new StringBuilder();

                                        if (!productsByType.ContainsKey(type))
                                        {
                                            result.AppendLine(string.Format("Error: Type {0} does not exists", type));
                                            break;
                                        }
                                        var products = productsByType[type];
                                        if (products.Count == 0) result.Append("Ok:");
                                        else
                                            result.Append("Ok: ");
                                        var products10 = products.Take(10);
                                        result.AppendLine(string.Join(", ", products10));
                                        break;
                                    }
                                case "price":
                                    {

                                        if (commands.Length == 7)
                                        {
                                            decimal from = decimal.Parse(commands[4]);
                                            decimal to = decimal.Parse(commands[6]);

                                            var products = GetFirstProductsFromToRange(from, to, productsByPrice).Values.ToList();
                                            if (products.Count == 0) result.Append("Ok:");
                                            else
                                            result.Append("Ok: ");
                                            var products10 = products.Take(10);
                                            result.AppendLine(string.Join(", ", products10));

                                        }
                                        if (commands.Length == 5)
                                        {
                                            if (commands[3] == "from")
                                            {
                                                decimal from = decimal.Parse(commands[4]);
                                                var products = GetFirstProductsFromRange(from, productsByPrice).Values.ToList();

                                                if (products.Count == 0) result.Append("Ok:");
                                                else
                                                    result.Append("Ok: ");
                                                var products10 = products.Take(10);
                                                result.AppendLine(string.Join(", ", products10));

                                            }
                                            if (commands[3] == "to")
                                            {
                                                decimal to = decimal.Parse(commands[4]);
                                                var products = GetFirstProductsToRange(to, productsByPrice).Values.ToList();
                                                if (products.Count == 0) result.Append("Ok:");
                                                else
                                                    result.Append("Ok: ");
                                                var products10 = products.Take(10);
                                                result.AppendLine(string.Join(", ", products10));
                                            }
                                        }

                                        break;
                                    }

                            }
                            break;
                        }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(result);
        }
    }
}
