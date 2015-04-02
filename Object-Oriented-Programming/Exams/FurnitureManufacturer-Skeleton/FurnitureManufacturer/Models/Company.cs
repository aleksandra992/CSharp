


namespace FurnitureManufacturer.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        ICollection<IFurniture> furnitures;


        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("The company name cannot be null, empty or less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            protected set
            {
                if (value.Length != 10 || !DigitsValidate(value))
                {
                    throw new ArgumentException("The registration number should be 10 symbols, and the symbols must be digits");
                }
                this.registrationNumber = value;
            }
        }

        private static bool DigitsValidate(string value)
        {
            foreach (var ch in value)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }

            }
            return true;
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
           this.furnitures= this.furnitures.OrderBy(x => x.Price).ThenBy(y => y.Model).ToList();
        }

        public void Remove(IFurniture furniture)
        {
            var toDelete = this.furnitures.FirstOrDefault(x => x.Equals(furniture));
            this.furnitures.Remove(toDelete);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            StringBuilder catalog = new StringBuilder();
           
                catalog.Append(string.Format("{0} - {1} - {2} {3}",
               this.Name,
               this.RegistrationNumber,
               this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
               this.Furnitures.Count != 1 ? "furnitures" : "furniture"
               ));
            
            foreach (var furniture in this.Furnitures)
            {
                catalog.Append("\n"+furniture.ToString());
                
            }
            return catalog.ToString();

        }
    }
}
