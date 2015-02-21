using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number n=");
            decimal n=decimal.Parse(Console.ReadLine());
           
            Console.WriteLine(ReverseDigits(n));
            Console.ReadKey();

        }
        static decimal ReverseDigits(decimal number)
        {
           // string reversedStr = new string(number.ToString().Reverse().ToArray());
            string s =number.ToString();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new String(arr);
           
            return decimal.Parse(s);
           
            
        }
    }
}
