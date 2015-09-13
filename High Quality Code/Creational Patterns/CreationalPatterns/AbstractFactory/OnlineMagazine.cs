using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Computers;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class OnlineMagazine
    {
        private readonly Seller seller;

        public OnlineMagazine(Seller seller)
        {
            this.seller = seller;
        }

        public AbstractFactory.Computers.Computer Computer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AbstractFactory.Factories.Seller Seller
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Toshiba SaleToshiba()
        {
            return this.seller.SaleToshiba();
        }

        public HP SaleHP()
        {
            return this.seller.SaleHP();
        }
    }
}
