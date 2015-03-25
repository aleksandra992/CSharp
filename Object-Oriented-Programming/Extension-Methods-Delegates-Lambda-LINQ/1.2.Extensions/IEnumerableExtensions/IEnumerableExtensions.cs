namespace Extensions.IEnumerableExtensions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using CheckType;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> en)
        {
            if (en.Count() == 0)
            {
                throw new ArgumentNullException("The collection doesn't have elements");
            }

            if (CheckType.CheckTypeOf<T>())
            {
                throw new Exception("The operation  sum is not allowed for string or string[]");
            }

            T sum = (dynamic)0;
            foreach (var item in en)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> en)
        {
            if (en.Count() == 0)
            {
                throw new ArgumentNullException("The collection doesn't have elements");
            }

            if (CheckType.CheckTypeOf<T>())
            {
                throw new Exception("The operation  sum is not allowed for string or string[]");
            }

            T product = (dynamic)1;
            foreach (var item in en)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> en) where T : IComparable
        {
            if (en.Count() == 0)
            {
                throw new ArgumentNullException("The collection doesn't have elements");
            }

            T min = en.First();
            foreach (var item in en)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> en) where T : IComparable
        {
            if (en.Count() == 0)
            {
                throw new ArgumentNullException("The collection doesn't have elements");
            }

            if (CheckType.CheckTypeOf<T>())
            {
                throw new Exception("The operation  sum is not allowed for string or string[]");
            }

            T max = en.First();
            foreach (var item in en)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> en)
        {
            if (en.Count() == 0)
            {
                throw new ArgumentNullException("The collection doesn't have elements");
            }

            if (CheckType.CheckTypeOf<T>())
            {
                throw new Exception("The operation  sum is not allowed for string or string[]");
            }

            double average = 0.0;
            average = (dynamic)en.Sum() / (double)en.Count();
            return average;
        }
    }
}
