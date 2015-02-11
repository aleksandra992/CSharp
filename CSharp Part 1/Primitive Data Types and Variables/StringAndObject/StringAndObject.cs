using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObject
{
    class StringAndObject
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object concatenation = first + " " + second;
            string concatenation2 = (string)concatenation;

            Console.WriteLine(concatenation +" "+ concatenation2);
        }
    }
}
