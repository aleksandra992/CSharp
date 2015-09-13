
using System;

namespace AbstractFactory
{
    using AbstractFactory.Factories;

    public class MainProgram
    {
        static void Main(string[] args)
        {
            var bestBuy = new BestBuy();
            var ebay = new OnlineMagazine(bestBuy);
            var toshiba = ebay.SaleToshiba();
            Console.WriteLine(toshiba.Seller);

            var amazon=new Amazon();
            var amazonOnline=new OnlineMagazine(amazon);
            var hp = amazonOnline.SaleHP();
            Console.WriteLine(hp.Seller);


        }
    }
}
