using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("enter the index");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(MaxElement(n, array));
            Console.ReadKey();
        }
        static int MaxElement(int start,int[]array)
        {
            int[] array1 = new int[array.Length - start];

            array1=array.Where(x => Array.IndexOf(array,x) > start).ToArray();
           return array1.OrderByDescending(x => x)
                .FirstOrDefault();

 
        }
    }
}
