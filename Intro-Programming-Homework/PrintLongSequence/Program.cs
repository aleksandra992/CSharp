using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            for (int i = 2; i < 1002; i++)
            {
                b = i;
                if (b % 2 == 1)
                {
                    b *= -1;
                }
                if (b == -1001)//after the last member of the array there is no comma
                {
                    Console.Write(+b);
                }
                else
                    Console.Write(+b + ", ");


            }
            Console.ReadKey();
        }
    }
}
