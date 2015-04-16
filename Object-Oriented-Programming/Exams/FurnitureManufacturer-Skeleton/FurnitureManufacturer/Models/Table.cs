namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Text;
    public class Table : Furniture, ITable, IFurniture
    {
        // TODO: Write all needed classes by implementing the interfaces in this namespace. You may delete this class
       
        private decimal length;
        private decimal width;
        public Table(string model, decimal price, decimal height, string material, decimal length, decimal width)
            : base(model, price, height, material)
        {
            this.Length = length;
            this.Width = width;

        }
        public decimal Length
        {
            get { return this.length; }
            protected set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("The table width cannot be less or equal to zero");
                }
                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            protected set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("The table width cannot be less or equal to zero");
                }
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return this.Length * this.Width; }
        }
        public override string ToString()
        {
          return base.ToString()+

           string.Format(" Length: {0}, Width: {1}, Area: {2}"
            , this.Length, this.Width, this.Area);
           
        }
    }
}
