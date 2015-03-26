namespace Animal_Hierarchy.Animals
{
    using System;
    public class Dog : Animal,ISound
    {
          public Dog(int age, string name,string sex):base(age,name,sex)
        {

        }

        public override string Sound()
        {
            return base.Sound() + " Bau!";
        }
    }
}
