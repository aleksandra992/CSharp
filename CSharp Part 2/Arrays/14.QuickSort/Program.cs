using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            QuickSort(array, 0, array.Length - 1);
            Console.Write(string.Join(",", array));
        }
        static void Swap(int[] numbers, int i, int j)
        {
            int pom = numbers[i];

            numbers[i] = numbers[j];
            numbers[j] = pom;
        }
        static void QuickSort(int[] elements, int left, int right)
        {
            int i, j;
            int pivot;
            pivot = elements[(left + right) / 2];
            i = left;
            j = right;
            while (true)
            {
                while (elements[i] < pivot) { i++; }
                while (elements[j] > pivot) { j--; }
                if (i < j)
                {
                    Swap(elements, i, j);
                    if (elements[i] == elements[j])
                    {
                        Swap(elements, i + 1, j);
                        i++;
                    }

                }
                else
                    break;

            }
            if (left < i - 1)
                QuickSort(elements, left, i - 1);
            if (i + 1 < right)
                QuickSort(elements, i + 1, right);
        }
    }
}
