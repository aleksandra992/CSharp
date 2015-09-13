using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    using AbstractFactory.Computers;

    public class Amazon : Seller
    {
        private const string SellerName = "Amazon";

        public override HP SaleHP()
        {
            var components = new List<string> {"mouse", "speakers"};
            var computer=new HP(components,SellerName);
            return computer;
        }

        public override Toshiba SaleToshiba()
        {
            var components = new List<string> { "mouse"};
            var computer = new Toshiba(components, SellerName);
            return computer;
        }
    }
}
