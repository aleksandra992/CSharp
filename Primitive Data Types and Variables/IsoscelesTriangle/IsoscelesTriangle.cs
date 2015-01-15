using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char symbol = (char)169;
            string firstLine = "   " + symbol + "   ";
            string secondLine = "  " + symbol+" "+symbol + "  ";
            string thirdLine = " " + symbol+"   "+symbol+ " ";
            string fourthLine = ""+symbol +" "+ symbol+" "+ symbol+" " + symbol;
            Console.WriteLine(firstLine);
            Console.WriteLine(secondLine);
            Console.WriteLine(thirdLine);
            Console.WriteLine(fourthLine);

        }
    }
}
