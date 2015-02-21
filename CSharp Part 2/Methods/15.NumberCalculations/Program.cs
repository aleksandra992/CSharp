using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The average of 1, 2 and 3 is " + Average(1, 2, 3));
            Console.WriteLine("The average of 1, 2, 3 and 4 is " + Average(1, 2, 3, 4));
            Console.WriteLine("The sum of 4, 5 and 3 is " + Sum(4, 5, 3));
            Console.WriteLine("The min of 1, 2 and 3 is " + Min(1, 2, 3));
            Console.WriteLine("The max of 5, 10 and 6 is " + Max(5, 10, 6));
            Console.WriteLine("The product of 1, 2 and 3 is " + Product(1, 2, 3));
            Console.WriteLine("The product of 1, 2,3,4,5 and 6 is " + Product(1, 2, 3, 4, 5, 6));
            Console.ReadKey();
        }
        static double Average(params int[] numbers)
        {
            return numbers.Average();
        }
      /*  static T Aver<T>(T[] numbers)
        {
            T num = numbers.Length;
            return 
                
            
        }
       * */
        
        static int Min(params int[] number)
        {
            return numbers.Min();
        }
        static int Max(params int[] numbers)
        {
            return numbers.Max();
        }
        static int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int Product(params int[] numbers)
        {
            int product = 1;
            foreach (var number in numbers)
            {

                product *= number;
            }
            return product;
        }
    }

