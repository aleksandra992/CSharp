using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer sorted array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("enter the position");
            int position = int.Parse(Console.ReadLine());
            if (LargerThanNeighbours(array, position) == true)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
        static bool LargerThanNeighbours(int[] numbers, int position)
        {
            if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                return true;
            return false;
        }
    }
}
