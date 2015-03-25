namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
   public class Program
    {
        public static void Main()
        {
            string[] array = { "aaaa", "bb", "hhhhhhh" };
            var rez = from s in array
                      where s.Length == array.Max().Length
                      select s;
           
            var result = array.OrderByDescending(a => a.Length).FirstOrDefault();
            Console.WriteLine("The longest string is {0}", result);
            Console.WriteLine("(LINQ)The longest string is");
            foreach (var item in rez)
            {
                Console.WriteLine(item);
            }
        }
    }
}
