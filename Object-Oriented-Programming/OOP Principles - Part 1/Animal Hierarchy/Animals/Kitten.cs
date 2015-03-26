namespace Animal_Hierarchy.Animals
{
    using System;
    public class Kitten : Cat,ISound
    {
        public Kitten(int age,string name,string sex):base(age,name,sex)
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
                if (value != "female")
                {
                    throw new ArgumentException("The sex can be onlye male or female");

                }
               base.Sex = value;           
              

            }
            
        }
       
       
    }
}
