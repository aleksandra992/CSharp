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
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
        }
    }
}
