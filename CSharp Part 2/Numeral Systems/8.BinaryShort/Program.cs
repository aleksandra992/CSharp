using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the short number");
            short number = short.Parse(Console.ReadLine());
            string s=Convert.ToString(number, 2).PadLeft(16,'0');
            Console.WriteLine(s);
        
        }
    }
}
