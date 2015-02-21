using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number n");
            int n = int.Parse(Console.ReadLine());
            int remainder = 0;
           
            List<int> binary = new List<int>();
            while (n != 0)
            {

                remainder=n % 2;
                binary.Add(remainder);
                n /= 2;

               
                


            }
            binary.Reverse();
           
            Console.WriteLine(string.Join("",binary));
           // Console.ReadKey();
        }
    }
}
