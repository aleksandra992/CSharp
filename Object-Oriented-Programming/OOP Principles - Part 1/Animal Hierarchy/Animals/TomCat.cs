namespace Animal_Hierarchy.Animals
{
    using System;

    public class TomCat : Cat,ISound
    {
        public TomCat(int age,string name,string sex):base(age,name,sex)
        {

        }
        public override string Sex
        {
            get
            {
                return base.Sex;
            }
            protected set
            {
                if (value != "male")
                {
                    throw new ArgumentException("The sex can be onlye male or female");

                }
                base.Sex = value;           
              
            }
        }
       
    }
}
