using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Average of   2.05 and 3.05 is" + Average(2.05, 3.05) + " Sum of 2,5.7,3,4  is " + Sum(2, 5.7, 3, 4) + " Max of  1,4,2,3,7.5 is " + Max(1, 4, 2, 3, 7.5) + " Min of 1,4,2,3,7.5 is " + Min(1, 4, 2, 3, 7.5) + " Product of 1,2.5,3,4.5f is " + Product(1, 2.5, 3, 4.5f));

        }

        static T Average<T>(params T[] numbers)
        {
            dynamic avg = 0;
            foreach (T k in numbers)
            {
                avg += k;
            }

            avg = avg / numbers.Length;
            return avg;


        }
        static T Min<T>(params T[] numbers)
        {
            return numbers.Min();
        }
        static T Max<T>(params T[] numbers)
        {
            return numbers.Max();
        }
        static T Sum<T>(params T[] numbers)
        {
            dynamic sum = 0; ;
            foreach (T k in numbers)
            {
                sum += k;
            }

            return sum;
        }
        static T Product<T>(params T[] numbers)
        {
            dynamic product = 1;
            foreach (var number in numbers)
            {

                product *= number;
            }
            return product;
        }
    }
}