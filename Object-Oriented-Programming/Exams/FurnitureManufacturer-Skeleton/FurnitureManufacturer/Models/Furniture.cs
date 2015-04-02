

namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;


        public Furniture(string model, decimal price, decimal height, string material)
        {
            this.Model = model;
            this.Price = price;
            this.Height = height;
            this.Material = material;

        }
        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                    throw new ArgumentException("The value cannot be empty, null or less than 3 symbols");
                this.model = value;
            }

        }

        public string Material
        {
            get;
            protected set;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
             set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("The price cannot be less or equal to 0");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("The height cannot be less or equal to 0");
                }
                this.height = value;
            }
        }

        public override bool Equals(object obj)
        {
            Furniture furniture=(Furniture)obj;
            if (!this.Model.Equals(furniture.Model))
                return false;
            if (!this.Price.Equals(furniture.Price))
                return false;
            if (!this.Height.Equals(furniture.Height))
                return false;
            if (Object.Equals(this.Material, furniture.Model))
                return false;
            return true;
        }
    }
}
