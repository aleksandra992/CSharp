using System;


namespace Person
{
   public class Testing
    {
       public  static void Main()
        {
            Person pesho = new Person("Pesho");
            Person gosho = new Person("Gosho",25);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}
