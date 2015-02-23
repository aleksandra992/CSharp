using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter words separated with space");
            List<string> words = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
           words= words.OrderBy(x=>x).ToList();
           Console.WriteLine(string.Join("\n", words.ToArray()));

        }
    }
}
