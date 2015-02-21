using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer sorted array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("enter the number n");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(AppearanceCount(array,n));
            Console.ReadKey();
        }
        static int AppearanceCount(int[] array,int number)
        {
             return array.Count(x => x == number);

 
        }
    }
}
