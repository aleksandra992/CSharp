using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the binary number (with the digits separated with space");
            string array = Console.ReadLine();
            int result = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += int.Parse(array[i].ToString()) * (int)Math.Pow(2, array.Length-1-i);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
