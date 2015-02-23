using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
                
            }
           
        }
    }
}
