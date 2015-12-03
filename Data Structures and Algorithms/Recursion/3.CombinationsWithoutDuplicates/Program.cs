
namespace _3.CombinationsWithoutDuplicates
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter n and k separated with single line");

            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            int[] result = new int[k];
            int[] array = Enumerable.Range(1, n).ToArray();
            CombinationsWithoutDuplicates(result, array, 0, 0);
        }


        public static void CombinationsWithoutDuplicates(int[] result, int[] arr, int k, int br)
        {
            if (k >= result.Length)
            {
                Console.WriteLine(string.Join(",", result));
                return;
            }

            for (var i = br; i < arr.Length; i++)
            {
                result[k] = arr[i];
                CombinationsWithoutDuplicates(result, arr, k + 1, i + 1);
            }
        }
    }
}
