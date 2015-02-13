using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter the second inetegr array separated with comma");
            int []array1 = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            if (array.Length != array1.Length)
            {
                Console.WriteLine("The arrays are not equal");
                return;

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array1[i])
                {
                    Console.WriteLine("The arrays are not equal");
                    return;
                }
            }
            Console.WriteLine("The arrays are equal");
        }
    }

