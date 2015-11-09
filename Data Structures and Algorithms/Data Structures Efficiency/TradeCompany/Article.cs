using System;

namespace TradeCompany
{
    public class Article : IComparable<Article>
    {
        public Article(string barCode, string vendor, double price)
        {
            this.BarCode = barCode;
            this.Vendor = vendor;
            this.Price = price;
        }

        public string BarCode { get; set; }

        public string Vendor { get; set; }

        public double Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.BarCode.CompareTo(other.BarCode);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", this.BarCode, this.Price, this.Vendor);
        }
    }
}
