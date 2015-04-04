namespace AcademyEcosystem
{
    using System;
    public class Lion:Animal,ICarnivore
    {
        private const int sizeInitialLion = 6;
        public Lion(string name,Point location):base(name,location,sizeInitialLion)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (this.Size * 2 >= animal.Size)
                {
                    this.Size += 1;
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;

        }
    }
}
