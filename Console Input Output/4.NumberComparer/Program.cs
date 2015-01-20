using System;
using System.Globalization;
using System.Threading;


namespace _4.NumberComparer
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
  CultureInfo.InvariantCulture;

            Console.Write("first number n=");
            float n = float.Parse(Console.ReadLine());
            Console.Write("second number m=");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("The greater is:{0}", (n > m) ? n : m);
        }
    }
}
