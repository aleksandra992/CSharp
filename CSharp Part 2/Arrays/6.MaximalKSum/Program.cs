using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter the number k");
            int k = int.Parse(Console.ReadLine());
            array = array.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(",", array.Take(k).ToArray()));
            
        }
    }

