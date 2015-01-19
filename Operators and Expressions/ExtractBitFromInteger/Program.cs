using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the number n and position p");
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if ((int)(n >> p) % 2 == 0)//move the bits from the number n, p positions to the right and check if the first bit from the right is 0 or 1 with checking if the number is odd or even
            {
                Console.WriteLine("0");
            }
            else
                Console.WriteLine("1");



        }
    }
}
