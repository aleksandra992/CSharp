using System;
using System.Linq;

namespace _3.CheckforAPlayCard
{
    class Program
    {
        static void Main()
        {
            string[] s = new string[] { "1", "2", "3", "4","5","6","7","8","9","10","J","Q","K","A"};
            Console.WriteLine("enter the sign");
            string sign = Console.ReadLine();
            if (s.Contains(sign))
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
