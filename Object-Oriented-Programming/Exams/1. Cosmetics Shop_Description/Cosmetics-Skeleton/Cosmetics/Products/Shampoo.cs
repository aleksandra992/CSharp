namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    public class Shampoo : Product, IShampoo, IProduct
    {

        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usageType)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usageType;

        }
        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                this.milliliters = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
            protected set
            {

                base.Price = value;
            }
        }
        public Common.UsageType Usage
        {
            get
            {
                return this.usage;
            }
            private set
            {
                Validator.CheckIfNull(value);
                this.usage = value;


            }
        }
        public override string Print()
        {
            return base.Print() + string.Format("\n  * Quantity: {0} ml\n  * Usage: {1}", this.Milliliters, this.Usage.ToString());
        }
    }
}
