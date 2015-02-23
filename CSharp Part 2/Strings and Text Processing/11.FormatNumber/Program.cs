using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
        int s = int.Parse(Console.ReadLine());
        

            Console.WriteLine("Dec {0,15:D}\nHex {1,15:x}\nPercentage{2,15:p}\nScinetific{3,15:e}", s,s,s/100.0,s );



        }
    }
}
