namespace Cooking.Dishes
{
    using System;
    using System.Collections.Generic;
    using Ingredients;

    public class Bowl
    {
        private List<Vegetable> vegetables;

        public Bowl()
        {
            this.vegetables = new List<Vegetable>();
        }

        public void Add(Vegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }

        public override string ToString()
        {
            return string.Join(" ", this.vegetables);
        }
    }
}
