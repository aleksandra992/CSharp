using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer sorted array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
           Console.WriteLine( FirstLargerThatNeighbours(array));
           //Console.ReadKey();

           
        }
        static bool LargerThanNeighbours(int[] numbers, int position)
        {
            if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                return true;
            return false;
        }
        static int FirstLargerThatNeighbours(int[] numbers)
        {
           
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (LargerThanNeighbours(numbers, i))
                {
                    return i;
                }
               

            }
            return -1;
 
        }
    }

