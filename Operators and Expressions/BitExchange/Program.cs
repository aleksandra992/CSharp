using System;
using System.Collections;


namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number(at most to be 32 bits)");
            /*   long number = long.Parse(Console.ReadLine());
               long number1 = ( (number&(1 << 3)) << 24) | number;
               long number2 = ( number&(1 << 4) << 25) | number;
               long number3 = (number&(1 << 5)<< 26) | number;
            

               long number11 = ((number & (1 << 24)) >> 21) | number;
               long number21 = ((number & (1 << 25)) >> 21) | number;
               long number22 = ((number & (1 << 26)) >> 21) | number;
               long newNumber1 = number1 | number2 | number3|number11|number21|number22;
               Console.WriteLine(newNumber1);
             */
           
            uint number = uint.Parse(Console.ReadLine());
            BitArray b = new BitArray(new int[] {(int) number });//convert the integer into array of bits(true or false)
           
            bool bit3 = b[3];//exchange the bits
            bool bit4 = b[4];
            bool bit5 = b[5];
            b[3] = b[24];
            b[4] = b[25];
            b[5] = b[26];
            b[24] = bit3;
            b[25] = bit4;
            b[26] = bit5;

            /*   
             * First desicion
             *  double newNumber = 0;
             * for (int i = 0; i <b.Length; i++)
                 {
                     if (b[i] == true)
                     {
                         newNumber+= Math.Pow(2, i);//convert the  bit number to integer
                         ////count the integer from a bit number based on Math(2^0+2^1+....)
                     }
                
                    
                 }
                 Console.WriteLine(newNumber);*/

            //Second desicion
            
            int[] array = new int[1];//make an array with one integer
            b.CopyTo(array, 0);//copy the array b into array[0] as a single integer
            Console.WriteLine((uint)array[0]);
           

        }
    }
}
