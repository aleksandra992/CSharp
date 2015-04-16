namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class Chair : Furniture, IChair, IFurniture
    {
        public Chair(string model, decimal price, decimal height, string material, int numberOfLegs)
            : base(model, price, height, material)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        private int numberOfLegs;
        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of legs cannot be equal or less than zero");
                }
                this.numberOfLegs = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                string.Format(" Legs: {0}",
                this.NumberOfLegs);
        }
    }
}
