


namespace AcademyEcosystem
{
    using System;
   public  class Zombie:Animal
    {
       private const int sizeZombie = 0;
       public Zombie(string name,Point location):base(name,location,sizeZombie)
       {

       }
       //TODO:Check if it is correct
       public override int GetMeatFromKillQuantity()
       {
           this.IsAlive = true;
           return 10;
       }
       
    }
}
