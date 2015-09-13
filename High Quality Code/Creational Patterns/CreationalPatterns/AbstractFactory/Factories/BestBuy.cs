namespace AbstractFactory.Factories
{
    using System.Collections.Generic;

    using AbstractFactory.Computers;

    public class BestBuy : Seller
    {

        private const string SellerName = "Best buy";

        public override HP SaleHP()
        {
            var components = new List<string> { "HDD", "speakers" };
            var computer = new HP(components, SellerName);
            return computer;
        }

        public override Toshiba SaleToshiba()
        {
            var components = new List<string> { "HDD" ,"mouse"};
            var computer = new Toshiba(components, SellerName);
            return computer;
        }
    }
}
