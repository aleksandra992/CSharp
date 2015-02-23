using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers separated with space");
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).
                Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(numbers.Sum());
        }
    }
}
