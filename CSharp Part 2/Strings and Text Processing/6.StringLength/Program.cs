using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string with <=20 characters");
            string str = Console.ReadLine();
            if (str.Length > 20)
            {
                Console.WriteLine("the string should be not bigger 20 characters");
                return;
            }
           str= str.PadRight(20, '*');
            Console.WriteLine(str);
        }
    }
}
