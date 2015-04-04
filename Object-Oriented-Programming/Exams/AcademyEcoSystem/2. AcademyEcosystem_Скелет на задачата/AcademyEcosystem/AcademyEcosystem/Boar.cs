namespace AcademyEcosystem
{
    using System;
    public class Boar:Animal,ICarnivore,IHerbivore
    {

        private const int sizeBoar = 4;
        public Boar(string name,Point location):base(name,location,sizeBoar)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (this.Size >= animal.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size += 1;
                return plant.GetEatenQuantity(2);
            }
            return 0;
        }
        public override void Update(int timeElapsed)
        {
            base.Update(timeElapsed);
        }
    }
}
