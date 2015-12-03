namespace NestedLoops
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Range(1, n).ToArray();
            int[] result = new int[n];
            NestedLoops(result, array, 0);
        }

        public static void NestedLoops(int[] result, int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Console.WriteLine(string.Join(",", result));
                return;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                result[k] = arr[i];
                NestedLoops(result, arr, k + 1);
            }
        }
    }
}
