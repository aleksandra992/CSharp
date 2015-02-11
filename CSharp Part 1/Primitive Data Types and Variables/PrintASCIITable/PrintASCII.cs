using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCIITable
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {

                Console.WriteLine("The symbol is {0} but the ASCII code is {1}", (char)i, i);
            }
        }
    }
}
