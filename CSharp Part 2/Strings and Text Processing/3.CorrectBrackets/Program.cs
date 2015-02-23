using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression");
            string str = Console.ReadLine();
            Console.WriteLine(CheckBrackets(str) ? "The brackets are correct" : "The brackets are not correct");
        }  

        private static bool CheckBrackets(string str)
        {
            int countLeftBrackets = 0;
            int countRightBrackets = 0;
            foreach (var s in str)
            {
                if (s == '(')
                {
                    countLeftBrackets++;
                }
                if (s == ')')
                {
                    countRightBrackets++;
                }


            }
            if (countLeftBrackets == countRightBrackets)
            {
                return true;
            }
            return false;
        }
    }
}
