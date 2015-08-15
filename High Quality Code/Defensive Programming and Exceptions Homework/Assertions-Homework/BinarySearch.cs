using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assertions_Homework
{
    public static class BinarySearchAlgorithms
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, string.Format(AssertionValidationMessages.ArrayLengthCannotBeZero,"arr"));
            Debug.Assert(arr != null,string.Format(AssertionValidationMessages.ValueCannotBeNull,"arr"));
            Debug.Assert(value != null,String.Format( AssertionValidationMessages.ValueCannotBeNull,"value"));
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, String.Format(AssertionValidationMessages.IndexMustBeBetweenTwoIndexes,"startIndex"));
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, String.Format(AssertionValidationMessages.IndexMustBeBetweenTwoIndexes,"endIndex"));
            Debug.Assert(startIndex <= endIndex, string.Format(AssertionValidationMessages.IndexMustBeBeforeAnotherIndex,"startIndex","endIndex"));
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    Debug.Assert(midIndex > 0 && midIndex < arr.Length,String.Format(AssertionValidationMessages.IndexMustBeBetweenTwoIndexes,"midIndex"));
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
