using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] =(char)( i + 65);
            }
            Console.WriteLine("Enter a word");
            string str = Console.ReadLine().ToUpper();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(Array.IndexOf(alphabet, str[i])+1+",");
            }
        }
    }
}
