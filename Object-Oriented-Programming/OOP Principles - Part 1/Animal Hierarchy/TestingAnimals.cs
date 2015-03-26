namespace Animal_Hierarchy
{
    using System;
    using Animal_Hierarchy.Animals;
    using System.Collections.Generic;
    public static class TestingAnimals
    {
        public static void Test()
        {
            List<Animal> animals = new List<Animal>(){
                new Cat(2,"Pesho","male"),
                new Cat(1,"Gosho","female"),
                new Dog(4,"Ivan","male"),
                new Frog(2,"Jumbo","female"),
                new Frog(4,"Jumbo","male"),
                new Kitten(1,"Kiki","female"),
                new TomCat(5,"Tom","male"),
                new TomCat(5,"Tom","male")
          
            };
            Dictionary<string, double> d = Animal.Average(animals);
            foreach (var item in d)
            {
                Console.WriteLine("The animal {0} has average age:{1}",item.Key,item.Value);
                
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item.Sound());
            }
            {
                
            }

            
        }
       
    }
}
