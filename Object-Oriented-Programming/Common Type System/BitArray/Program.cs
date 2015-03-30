using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            BitArray array = new BitArray((ulong)10111);
         
         
            Console.WriteLine("First array {0}",array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
                
            }
            array[1] = 1;
            Console.WriteLine("The first array after changing the second bit is:");

            foreach (var item in array)
            {
                Console.WriteLine(item);

            }
            BitArray array2 = new BitArray((ulong)10111);
            Console.WriteLine("Second array {0}",array2);
            foreach (var item in array2)
            {
                Console.WriteLine(item);

            }

            BitArray array3 = new BitArray((ulong)10111);
            Console.WriteLine("Third array {0}",array3);
            foreach (var item in array3)
            {
                Console.WriteLine(item);

            }

            if (array.Equals(array2))
            {
                Console.WriteLine("The first and second array are same");
            }
            else
                Console.WriteLine("The first and second array are different");
            if (array2.Equals(array3))
            {
                Console.WriteLine("The second and third array are same");
            }
            else
                Console.WriteLine("The second and third array are different");

            Console.WriteLine(array == array2);
            Console.WriteLine(array2==array3);
        }
    }
}
