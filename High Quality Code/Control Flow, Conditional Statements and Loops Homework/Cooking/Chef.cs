namespace Cooking
{
    using System;
    using Dishes;
    using Ingredients;

    public class Chef
    {
        public Bowl Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
            return bowl;
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();
            return bowl;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();
            return carrot;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();
            return potato;           
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;           
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }       
    }
}