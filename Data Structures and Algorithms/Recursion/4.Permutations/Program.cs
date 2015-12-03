namespace _4.Permutations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Range(1, n).ToArray();
            int[] result = new int[n];
            Permutations(result, array, 0);

        }

        public static void Permutations(int[] result, int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Console.WriteLine(string.Join(",", result));

            }
            else
            {
                Permutations(result, arr, k + 1);
                for (var i = 0; i < arr.Length; i++)
                {
                    result[k] = arr[i];
                    Permutations(result, arr, k + 1);
                    result[i] = arr[k];
                }
            }
        }

        public static void Swap(ref int first, ref int second)
        {
            int oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}
