using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter integer number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit as word is "+GetLastAsWord(n));
           // Console.ReadKey();
        }
        static string GetLastAsWord(int number)
        {
            string[] digitWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int lastDigit=number % 10;
            return digitWords[lastDigit];

        }
    }
}
