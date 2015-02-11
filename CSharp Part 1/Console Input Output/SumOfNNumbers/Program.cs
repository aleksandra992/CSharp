using System;
using System.Collections.Generic;

namespace _9.SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n=");
            int n=int.Parse(Console.ReadLine());
            float sum=0;
            for (int i = 0; i < n; i++)
            {
                sum += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("the sum is {0}", sum);
        }
    }
}
