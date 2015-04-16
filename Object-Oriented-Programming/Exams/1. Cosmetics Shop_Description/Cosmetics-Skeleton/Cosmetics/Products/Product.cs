namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using System.Text;
    using Common;
    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        private const int maxLenghtName = 10;
        private const int minLenghtName = 3;
        private const int maxLenghtBrand = 10;
        private const int minLenghtBrand = 2;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        //Virtual is for a childs that want to change those properties..for a case :)
        public virtual string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The product name cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value, Product.maxLenghtName, Product.minLenghtName, string.Format("Product name must be between {0} and {1} symbols long!", Product.minLenghtName, Product.maxLenghtName));
                //Validate.Validation(value, 3, 10, "Product name");
                this.name = value;
            }
        }

        public virtual string Brand
        {
            get { return this.brand; }
            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "The brand cannot be null or empty");
                //my own validation for min and max
                // Validate.Validation(value, 2, 10, "Product brand");
                Validator.CheckIfStringLengthIsValid(value, Product.maxLenghtBrand, Product.minLenghtBrand, string.Format("Product brand must be between {0} and {1} symbols long!", Product.minLenghtBrand, maxLenghtBrand));
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("The price cannot be 0 or less than 0");
                }
                this.price = value;
            }
        }

        public GenderType Gender
        {

            get
            {
                return this.gender;
            }
            protected set
            {
                Validator.CheckIfNull(value);
                this.gender = value;
            }
        }

        public virtual string Print()
        {
            StringBuilder productString = new StringBuilder();
            productString.Append(string.Format("- {0} - {1}:", this.Brand, this.Name));
            productString.Append(string.Format("\n  * Price: ${0}", this.Price));
            productString.Append(string.Format("\n  * For gender: {0}", this.Gender.ToString()));
            return productString.ToString();
        }
    }
}
