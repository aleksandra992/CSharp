using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            decimal eps=0.000001M;
            Console.WriteLine("Enter the first number to be compared");
            decimal firstNumber=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            if (Math.Abs(firstNumber - secondNumber) >=eps)
            { 
                Console.WriteLine("The numbers are not equal");
            }
            else
                Console.WriteLine("The numbers are equal");

        }
    }
}
