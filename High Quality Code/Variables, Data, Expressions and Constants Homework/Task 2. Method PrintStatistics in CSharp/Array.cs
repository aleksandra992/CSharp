namespace PrintArrayStatistics
{
    using System;

    public class Array
    {
        /// <summary>
        /// Method for max element in array
        /// </summary>
        /// <param name="numbers">Array with double values</param>
        /// <returns>Return the max element in the array</returns>  
        public static double GetMaxElement(double[] numbers)
        {

            double maxElement = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];
                if (number > maxElement)
                {
                    maxElement = number;
                }
            }
            return maxElement;

        }

        /// <summary>
        /// Method for min element in array
        /// </summary>
        /// <param name="numbers">Array with double values</param>
        /// <returns>Return the min element in the array</returns>
        public static double GetMinElement(double[] numbers)
        {
            double minElement = double.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];
                if (number < minElement)
                {
                    minElement = number;
                }

            }
            return minElement;
        }

        /// <summary>
        /// Method for sum of elements in array
        /// </summary>
        /// <param name="numbers">Array with double values</param>
        /// <returns>The sum of the elements</returns>
        public static double GetSum(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        
        /// <summary>
        /// Method for average in array
        /// </summary>
        /// <param name="numbers">Array with double values</param>
        /// <returns></returns>
        public static double GetAverage(double[] numbers)
        {
            double average;
            average = GetSum(numbers) / numbers.Length;
            return average;
            
        }

        /// <summary>
        /// The method prints Math Statistics of array(min, max and average)
        /// </summary>
        /// <param name="arr">Array with double values</param>
        public static void PrintStatistics(double[] arr)
        {

            Console.WriteLine("The max element is {0}",GetMaxElement(arr));
            Console.WriteLine("The min element is {0}",GetMinElement(arr));
            Console.WriteLine("The average of the elements is {0}",GetAverage(arr));
        }
    }
}