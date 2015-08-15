using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertions_Homework
{
    public class SortingAlgorithms
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, string.Format(AssertionValidationMessages.ArrayLengthCannotBeZero, "arr"));
            Debug.Assert(arr != null, string.Format(AssertionValidationMessages.ValueCannotBeNull, "arr"));
            int startingLength = arr.Length;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
            Debug.Assert(arr.Length == startingLength, string.Format(AssertionValidationMessages.InvalidResultArrayLength, "arr"));
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex < arr.Length && startIndex >= 0, String.Format(AssertionValidationMessages.IndexMustBeBetweenTwoIndexes, "startIndex"));
            Debug.Assert(endIndex > 0 && endIndex < arr.Length, String.Format(AssertionValidationMessages.IndexMustBeBetweenTwoIndexes, "endIndex"));
            Debug.Assert(startIndex < endIndex, string.Format(AssertionValidationMessages.IndexMustBeBeforeAnotherIndex, "startIndex", "endIndex"));
            Debug.Assert(arr.Length > 0, string.Format(AssertionValidationMessages.ArrayLengthCannotBeZero, "arr"));
            Debug.Assert(arr != null, string.Format(AssertionValidationMessages.ValueCannotBeNull, "arr"));
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }
            Debug.Assert(minElementIndex >= 0 && minElementIndex < arr.Length);
            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }
    }
}
