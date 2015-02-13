using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer sorted array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter element n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The position of {0} is {1} starting from 0",n,Array.BinarySearch(array,n));
            
        }
    }

