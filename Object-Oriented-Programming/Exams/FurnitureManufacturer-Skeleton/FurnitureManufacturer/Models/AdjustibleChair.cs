namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    
    public class AdjustableChair:Chair,IAdjustableChair,IFurniture
    {
        public AdjustableChair(string model,decimal price,decimal height,string material,int numberOfLegs)
            :base(model,price,height,material,numberOfLegs)
        {

        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }

    }
}
