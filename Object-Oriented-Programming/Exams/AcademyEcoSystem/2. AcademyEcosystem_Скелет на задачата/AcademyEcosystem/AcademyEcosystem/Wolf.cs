namespace AcademyEcosystem
{
    using System;
    public class Wolf:Animal,ICarnivore
    {
        private const int sizeWolf = 4;
        public Wolf(string name,Point location):base(name,location,sizeWolf)
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
                else
                {
                    if (animal.State == AnimalState.Sleeping)
                    {
                        return animal.GetMeatFromKillQuantity();
                    }
                }
            }
            return 0;
        }
    }
}
