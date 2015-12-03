using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frames
{
    class Program
    {
        static SortedSet<string> allPermutations = new SortedSet<string>();
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                pairs.Add(new Tuple<int, int>(input[0], input[1]));

            }

            // string[] arr = { "apple", "banana", "orange" };
            GeneratePermutations(pairs, 0);
            PrintPermutations();
        }

        static void GeneratePermutations(List<Tuple<int, int>> arr, int k)
        {
            if (k >= arr.Count)
            {
                string permutation = String.Join(" | ", arr);
                allPermutations.Add(permutation);
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                arr[k] = new Tuple<int, int>(arr[k].Item2, arr[k].Item1);
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Count; i++)
                {
                    Tuple<int, int> oldFirst = arr[k];
                    arr[k] = arr[i];
                    arr[i] = oldFirst;
                    GeneratePermutations(arr, k + 1);
                    arr[k] = new Tuple<int, int>(arr[k].Item2, arr[k].Item1);
                    GeneratePermutations(arr, k + 1);
                    Tuple<int, int> oldFirst1 = arr[k];
                    arr[k] = arr[i];
                    arr[i] = oldFirst1;
                }
            }
        }

        static void Print(List<KeyValuePair<int, int>> arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap(Tuple<int, int> first, Tuple<int, int> second)
        {
            Tuple<int, int> oldFirst = first;
            first = second;
            second = oldFirst;
        }


        static void PrintPermutations()
        {
            Console.WriteLine(allPermutations.Count);
            foreach (var perm in allPermutations)
            {
                Console.WriteLine(perm);
            }
        }
    }
}
