namespace Animal_Hierarchy.Animals
{
    using System;

    public class Frog : Animal,ISound
    {
          public Frog(int age, string name,string sex):base(age,name,sex)
        {

        }

        public override string Sound()
        {
            return base.Sound() + " krek!";
        }
    }
}
