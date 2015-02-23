using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");

            List<string> words = Console.ReadLine().Split(new char[] { ' ', '\t', '\n', '.', ',', '?', }, StringSplitOptions.RemoveEmptyEntries).ToList();
            HashSet<string> uniqueWords = new HashSet<string>();
            foreach (var item in words)
            {
                uniqueWords.Add(item);
            }
            foreach (var item in uniqueWords)
            {

                Console.WriteLine("{0}-{1}times",item,words.Where(x=>x==item).Count());
            }
            {

            }
        }
    }
}
