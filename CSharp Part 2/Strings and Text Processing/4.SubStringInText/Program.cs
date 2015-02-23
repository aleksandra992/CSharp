using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string to check");
            string str = Console.ReadLine().ToLower();
            Console.WriteLine("enter the substring");
            string subStr=Console.ReadLine().ToLower();
            int br = 0;
            int startIndex = 0;
            while (str.IndexOf(subStr,startIndex) != -1)
            {
                startIndex = str.IndexOf(subStr, startIndex) + subStr.Length;
                br++;

            }

         //   Console.WriteLine(Regex.Matches(str, subStr, RegexOptions.IgnoreCase).Count);
            Console.WriteLine(br);
        }
    }
}
