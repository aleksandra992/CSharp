using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
             Console.WriteLine("Enter the first char array separated with comma");
            char[] array = Console.ReadLine().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x)).ToArray();
            Console.WriteLine("Enter the second char array separated with comma");
            char[] array1 = Console.ReadLine().Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x)).ToArray();
            if(array.Length!=array1.Length)
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

