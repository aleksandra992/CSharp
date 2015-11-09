namespace TradeCompany
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);

            for (int i = 0; i < 500000; i++)
            {
                articles.Add((double)i, new Article(i + "123", "Vendor #" + i, (double)i));
            }

            var productsWithPrice15to25 = GetFirstProductsFromRange(15, 25, articles);
            Console.WriteLine("Products in range [15-25]");
            Console.WriteLine("------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, productsWithPrice15to25));
        }

        public static OrderedMultiDictionary<double, Article>.View GetFirstProductsFromRange(double from, double to, OrderedMultiDictionary<double, Article> articles)
        {
            return
                articles
                .Range(from, true, to, true);
        }
    }
}
