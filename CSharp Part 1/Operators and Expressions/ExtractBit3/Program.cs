using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBit3
{
    class Program
    {
        static void Main()
        {
            uint mask = 8;
            Console.WriteLine("Enter unsigned integer number");
            uint number =uint.Parse( Console.ReadLine());
            uint rez=mask&number;//the mask is 000....00100, so when you do an 'and' operation with the number you can see if all the bits are 0 or not and conclude if the third bit is 1 or 0
            if (rez == 0)
            {
                Console.WriteLine("bit #3 is 0");
            }
            else
                Console.WriteLine("bit #3 is 1");


        }
    }
}
