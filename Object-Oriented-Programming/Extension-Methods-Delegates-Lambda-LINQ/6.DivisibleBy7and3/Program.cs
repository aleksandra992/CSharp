namespace _6.DivisibleBy7and3
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 5, 49 };

            var numbersDividableWith7 = numbers.Where(n => (n % 7) == 0).ToArray();
            Console.WriteLine("The numbers that are divisable with 7 are");
            Console.WriteLine(string.Join(" ",numbersDividableWith7));

            var numbersLinq = from num in numbers
                              where ((num % 7) == 0)
                              select num;
            Console.WriteLine("(LINQ)The numbers that are divisable with 7 are");
            Console.WriteLine(string.Join(" ", numbersLinq));
                            
        }
    }
}
