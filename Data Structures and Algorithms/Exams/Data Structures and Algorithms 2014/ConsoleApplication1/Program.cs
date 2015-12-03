using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const int n = 3;

        static string input;
        static int k;
        static string[] objects = new string[n]
        {
        "L", "R", "S"
        };

        static int[] arr;

        static void Main()
        {
            input = Console.ReadLine();
            int numberOfStars = input.Count(x => x == '*');
            k = numberOfStars;
            arr = new int[numberOfStars];

            Console.WriteLine(Math.Pow(3, k));
            GenerateVariationsWithRepetitions(0);
        }

        static void GenerateVariationsWithRepetitions(int index)
        {
            if (index >= k)
            {
                PrintVariations();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1);
                }
            }
        }

        static void PrintVariations()
        {
            //   Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
            var copyInput = string.Copy(input).ToCharArray();
            int counter = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (copyInput[i] == '*')
                {
                    copyInput[i] = objects[arr[counter]][0];
                    counter++;
                }

            }
            Console.WriteLine(copyInput);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(objects[arr[i]] + " ");
            //}
            //Console.WriteLine();
        }

    }
}
