using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Bit_Exchange_Advanced_
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the number n=");
            uint number = 0;
            try
            {
                 number = uint.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Out of range..The number is bigger than 32 bits try another number");
                Main();
                return;
            }
            Console.Write("enter p=");
            int p=int.Parse(Console.ReadLine());
            Console.Write("enter q=");
            int q = int.Parse(Console.ReadLine());
            Console.Write("enter k=");
            int k = int.Parse(Console.ReadLine());
          
            

            if (((p < q) && (q < (p + k - 1))) || ((p < (q + k - 1)) && ((q + k - 1) < (p + k - 1))))
            {
                Console.WriteLine("overlapping");
                return;
            }

            if ((p + k - 1) > 31 || (q + k - 1) > 31)
            {
                Console.WriteLine("oversize");
                return;
            }
            BitArray b = new BitArray(new int[] { (int)number });
            int j=q;
            bool hint;
            for (int i = p; i <= (p + k - 1); i++)
            {
                hint = b[i];
                b[i] = b[j];
                b[j] = hint;
                j++;
               
            }
            int[] array = new int[1];//make an array with one integer
            b.CopyTo(array, 0);//copy the array b into array[0] as a single integer
            Console.WriteLine((uint)array[0]);
        }
    }
}
