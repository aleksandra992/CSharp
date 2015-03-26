namespace Animal_Hierarchy.Animals
{
    
    using System;
    using System.Collections.Generic;
    public class Cat : Animal,ISound
    {
        public Cat(int age, string name,string sex):base(age,name,sex)
        {

        }
     
        public override string Sound()
        {
            return base.Sound()+" Miau!";
        }

        
    }
}
