namespace IfStatements
{
    using System;
    using Cooking.Ingredients;

    public class PotatoIfStatement
    {
        private Potato potato;

        public void CookPotato()
        {
            this.potato = new Potato();
            if (this.potato != null)
            {
                if (this.CheckIfPotatoIsPeeledAndNotRooten(this.potato))
                {
                    Cook(this.potato);
                }
            }
        }

        public void Cook(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfPotatoIsPeeledAndNotRooten(Potato potato)
        {
            if (this.potato.IsPeeled && !this.potato.IsRooten)
            {
                return true;
            }

            return false;
        }
    }
}
