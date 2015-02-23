using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (var s in str)
            {
                result.Append(String.Format("\\u{0:X4}", (int)s));
                
            }
            Console.WriteLine(result.ToString());
        }
    }
}
