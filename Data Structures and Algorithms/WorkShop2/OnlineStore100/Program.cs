namespace OnlineStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
   // using Wintellect.PowerCollections;

    public class Product : IComparable<Product>
    {
        public Product(string name, decimal price, string producer)
        {
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2:0.00}", this.Name, this.Producer, this.Price);
        }

        public int CompareTo(Product other)
        {
            if (this == other)
            {
                return 0;
            }
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Producer.CompareTo(other.Producer);
            }
            if (result == 0)
            {
                result = this.Price.CompareTo(other.Price);
            }

            return result;
        }
    }

    public class Startup
    {
        private const string ProductAddedMessage = "Product added";
        private const string ProductDeletedMessage = " products deleted";
        private const string ProductNotFoundMessage = "No products found";

        static Dictionary<string, List<Product>> productsByNameAndProducer = new Dictionary<string, List<Product>>();
        static Dictionary<string, List<Product>> productsByName = new Dictionary<string, List<Product>>();
        static Dictionary<decimal, List<Product>> productsByPrice = new Dictionary<decimal, List<Product>>();
        static Dictionary<string, List<Product>> productsByProducer = new Dictionary<string, List<Product>>();
        static StringBuilder sb = new StringBuilder();

        static void Main()
        {
            //var input = File.ReadAllText("../../input.txt");
            //var str = new StringReader(input);
            //Console.SetIn(str);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                var indexOfWhitespace = command.IndexOf(' ');
                var commandName = command.Substring(0, indexOfWhitespace);
                var commandParameter = command.Substring(indexOfWhitespace + 1);
                string[] parameters = commandParameter.Split(';');

                if (commandName == "AddProduct")
                {
                    var product = new Product(parameters[0], decimal.Parse(parameters[1]), parameters[2]);
                    var nameProducer = parameters[0] + parameters[2];
                    if (!productsByName.ContainsKey(product.Name))
                    {
                        productsByName.Add(product.Name, new List<Product>());
                    }

                    if (!productsByPrice.ContainsKey(product.Price))
                    {
                        productsByPrice.Add(product.Price, new List<Product>());
                    }

                    if (!productsByProducer.ContainsKey(product.Producer))
                    {
                        productsByProducer.Add(product.Producer, new List<Product>());
                    }

                    if (!productsByNameAndProducer.ContainsKey(nameProducer))
                    {
                        productsByNameAndProducer.Add(nameProducer, new List<Product>());
                    }

                    productsByName[product.Name].Add(product);
                    productsByPrice[product.Price].Add(product);
                    productsByProducer[product.Producer].Add(product);
                    productsByNameAndProducer[nameProducer].Add(product);

                    sb.AppendLine(ProductAddedMessage);
                }
                else if (commandName == "DeleteProducts")
                {
                    if (parameters.Count() == 1)
                    {
                        if (!productsByProducer.ContainsKey(parameters[0]))
                        {
                            sb.AppendLine(ProductNotFoundMessage);

                        }
                        else
                        {
                            var deletedProduct = productsByProducer[parameters[0]];

                            var count = deletedProduct.Count;
                            foreach (var item in deletedProduct)
                            {
                                productsByNameAndProducer.Remove(item.Name + item.Producer);
                                productsByName.Remove(item.Name);
                                productsByPrice.Remove(item.Price);
                            }

                            productsByProducer.Remove(parameters[0]);
                            sb.AppendLine(count + ProductDeletedMessage);
                        }
                    }
                    else if (parameters.Count() == 2)
                    {
                        var nameProducer = parameters[0] + parameters[1];

                        if (productsByNameAndProducer.ContainsKey(nameProducer))
                        {

                            var deletedPorduct = productsByNameAndProducer[nameProducer];
                            var count = deletedPorduct.Count;
                            foreach (var item in deletedPorduct)
                            {
                                productsByName.Remove(item.Name);
                                productsByPrice.Remove(item.Price);
                                productsByProducer.Remove(item.Producer);
                            }

                            productsByNameAndProducer.Remove(nameProducer);
                            sb.AppendLine(count + ProductDeletedMessage);
                        }
                        else
                        {
                            sb.AppendLine(ProductNotFoundMessage);
                        }
                    }
                }
                else if (commandName == "FindProductsByName")
                {

                    if (!productsByName.ContainsKey(parameters[0]))
                    {
                        sb.AppendLine(ProductNotFoundMessage);
                    }
                    else
                    {
                        var findByName = productsByName[parameters[0]]
                            .OrderBy(s => s.ToString());

                        foreach (var item in findByName)
                        {
                            sb.AppendLine("{" + item.ToString() + "}");
                        }
                    }

                }
                else if (commandName == "FindProductsByPriceRange")
                {
                    var from = decimal.Parse(parameters[0]);
                    var to = decimal.Parse(parameters[1]);

                    var findByPriceRange = productsByPrice
                        .Where(x => x.Key >= from && x.Key <= to).SelectMany(p => p.Value)
                        .OrderBy(s => s.ToString())
                        .ToList();

                    if (findByPriceRange.Count > 0)
                    {
                        foreach (var item in findByPriceRange)
                        {
                            sb.AppendLine("{" + item.ToString() + "}");
                        }
                    }
                    else
                    {
                        sb.AppendLine(ProductNotFoundMessage);
                    }
                }
                else if (commandName == "FindProductsByProducer")
                {

                    if (!productsByProducer.ContainsKey(parameters[0]))
                    {
                        sb.AppendLine(ProductNotFoundMessage);

                    }
                    else
                    {
                        var findByProducer = productsByProducer[parameters[0]]
                            .OrderBy(s => s.ToString());

                        foreach (var item in findByProducer)
                        {
                            sb.AppendLine("{" + item.ToString() + "}");
                        }
                    }
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}