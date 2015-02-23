using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
           Console.WriteLine(string.Join("", s.Reverse().ToArray()));

        }
    }
}
