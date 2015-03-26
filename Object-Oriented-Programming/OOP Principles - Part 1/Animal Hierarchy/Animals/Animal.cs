namespace Animal_Hierarchy.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;

       
        public Animal(int age,string name,string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("The age should be between 0 and 1000");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
           protected set
            {
                
                foreach (var letter in value)
                {
                    if (!char.IsLetter(letter))
                    {
                        throw new ArgumentException("Invalid name");
                    }

                }
                this.name = value;
            }
        }
        public virtual string Sex
        {
            get
            {
                return this.sex;
            }
           protected set
            {
                if (value == "male" || value == "female")
                {
                    this.sex = value;
                }
                else
                {
                    throw new ArgumentException("The sex can be onlye male or female");
                }
                

            }
        }

        public virtual string Sound()
        {
            return String.Format("I am {0}", this.GetType().Name);
        }
        public static Dictionary<string,double> Average(IEnumerable<Animal> animals)
        {
            var GroupedAnimals= animals.GroupBy(x => x.GetType().Name);
            Dictionary<string,double> averages = new Dictionary<string,double>();
            foreach (var group in GroupedAnimals)
                averages[group.Key.ToString()]=group.Average(x => x.age);
            return averages;
                
            
        }
       

    }


}
