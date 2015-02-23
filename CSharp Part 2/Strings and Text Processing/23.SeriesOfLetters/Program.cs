using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string text = Console.ReadLine();
          
            StringBuilder result = new StringBuilder();
            char pom ='\0';
                
            for (int i = 1; i < text.Length; i++)
            {
                
               if(text[i]!=pom)
               {
                   result.Append(text[i]);
               }
               pom = text[i];
 
            }
            Console.WriteLine(result.ToString());
        }
    }
}
