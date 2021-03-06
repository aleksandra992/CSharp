﻿namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            // TODO: Implement this method
            ITable table = new Table(model, price, height, this.GetMaterialType(materialType).ToString(),length,width);
            return table;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // TODO: Implement this method
            IChair chair = new Chair(model, price, height,this.GetMaterialType( materialType).ToString(), numberOfLegs);
            return chair;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            IAdjustableChair adjustibleChair = new AdjustableChair(model, price, height, this.GetMaterialType(materialType).ToString(), numberOfLegs);
            return adjustibleChair;
            // TODO: Implement this method
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            IConvertibleChair convertibleChair = new ConvertibleChair(model, price, height, this.GetMaterialType(materialType).ToString(), numberOfLegs);
            return convertibleChair;
            // TODO: Implement this method
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
