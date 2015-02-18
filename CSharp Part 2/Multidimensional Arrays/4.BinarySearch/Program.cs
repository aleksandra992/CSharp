using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Array.Sort(array);
            Console.WriteLine("Enter integer k=");
            int k = int.Parse(Console.ReadLine());

           Console.WriteLine(array[ Array.BinarySearch(array,k)-1]);
        
        }
    }
}
