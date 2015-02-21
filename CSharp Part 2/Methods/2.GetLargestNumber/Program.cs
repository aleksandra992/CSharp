using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three integers");
            int n1=int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximum is " + GetMax(n1, GetMax(n2, n3)));
            //Console.ReadKey();
            
        }
        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }
    }
}
