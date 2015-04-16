namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;
    public class ConvertibleChair : Chair, IConvertibleChair, IFurniture
    {
        private bool isConverted;
        private decimal initialHeight;


        public ConvertibleChair(string model,decimal price,decimal height,string material,int numberOfLegs)
            :base(model,price,height,material,numberOfLegs)
        {
            isConverted = false;
        }
        private decimal InitialHeight
        {
            get
            {
                return this.initialHeight;
            }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentException("The height cannot be less or equal to 0");
                }
                this.initialHeight = value;
            }
        }
        public bool IsConverted
        {
            get
            {
                return this.isConverted;
            }
            private set
            {
                this.isConverted = value;
            }
        }
        public override decimal Height//od nih..treba da smenam nesto vo get
        {
            get
            {
                if (this.isConverted)
                {
                    return 0.01m;
                }
                else
                return base.Height;
            }
            protected set
            {
                base.Height = value;
            }
        }
        public void Convert()
        {
            this.isConverted = !this.isConverted;
            //if (IsConverted == false)//if is normal-put it to converted
            //{
            //    this.InitialHeight = this.Height;
            //    this.Height = 0.10m;
            //    IsConverted = true;
            //}

            //else
            //{
            //    this.Height = this.InitialHeight;
            //    IsConverted = false;
            //}
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
