namespace OrderedBag
{
    using Wintellect.PowerCollections;
    using System.Linq;
    using System.Collections.Generic;
    using System;

    public class Startup
    {
        public static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();

            for (int i = 0; i < 500000; i++)
            {
                products.Add(new Product(i, "Product #" + i));
            }

            var productsWithPrice15to25 = GetFirst20ProductsFromRange(15, 25, products);
            var productsWithPrice25to35 = GetFirst20ProductsFromRange(25, 35, products);
            Console.WriteLine("Products in range [15-25]");
            Console.WriteLine("------------------------");
            Console.WriteLine(string.Join(Environment.NewLine,productsWithPrice15to25));
            Console.WriteLine();
            Console.WriteLine("Products in range [25-35]");
            Console.WriteLine("------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPrice25to35));
        }

        public static IEnumerable<Product> GetFirst20ProductsFromRange(double from, double to, OrderedBag<Product> products)
        {
            return
                products.Range(products.FirstOrDefault(x => x.Price >= from), true, products.LastOrDefault(x => x.Price <= to), true)
                .Take<Product>(20);

        }



    }
}
