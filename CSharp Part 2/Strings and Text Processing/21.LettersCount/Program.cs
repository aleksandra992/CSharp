using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            HashSet<char> strUnique = new HashSet<char>();
            foreach (var item in str)
            {
                strUnique.Add(item);
                
            }
            foreach (var item in strUnique)
            {
                if (char.IsLetter(item))
                {
                    Console.WriteLine("{0}-{1} times", item, str.Where(x => x == item ).Count());
                }
            }
            }
    }
}
