

namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    //imaah ispusteno abstract
    public abstract class Furniture : IFurniture
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
        public virtual string Model//nemaah virtual
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The model cannot be empty or null ");
                if (value.Length < 3)
                    throw new ArgumentException("The model cannot have less than 3 symbols");
                this.model = value;
            }

        }

        public virtual string Material//nemaah virtual
        {
            get;
            protected set;//koga nemame proverki pravime samo properti
        }

        public virtual decimal Price//nemaah virtual
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

        public virtual decimal Height//nemaah virtual
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
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.Model, this.Material, this.Price, this.Height);
        }
    }
}
