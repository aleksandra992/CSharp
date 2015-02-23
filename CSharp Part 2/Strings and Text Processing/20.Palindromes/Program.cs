using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            List<string> text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?', ':', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        StringBuilder result=new StringBuilder();
            foreach (var word in text)
            {
                if (IsPalindrom(word))
                {
                    result.Append(" ");
                    result.Append(word);
                }
            }
           Console.WriteLine(result.ToString().Trim(' '));
        }
        static bool IsPalindrom(string s)
        {
            char[] reversedS = s.Reverse().ToArray();
            string reverse = new string(reversedS);
            if (reverse == s)
            {
                return true;
            }
            return false;

        }
    }
}
