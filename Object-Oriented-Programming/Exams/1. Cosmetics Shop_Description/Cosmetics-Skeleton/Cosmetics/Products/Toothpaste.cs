namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;

    public class Toothpaste : Product, IToothpaste, IProduct
    {

        private ICollection<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, ICollection<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredientsList = new List<string>(ingredients);
        }


        public ICollection<string> IngredientsList
        {
            get
            {
                return new List<string>(this.ingredientsList);
            }
            private set{
                foreach (var ingredient in value)
                {
                    Validate.Validation(ingredient, 4, 12, "Each ingredient");
                    
                }
                this.ingredientsList = new List<string>(value);
                
            }
        }
        public string Ingredients
        {
            get { return string.Join(", ", this.IngredientsList); }
        }

        public override string Print()
        {
            return base.Print() + string.Format("\n  * Ingredients: {0}",this.Ingredients);
        }
    }
}
