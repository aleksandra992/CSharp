using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
        }
        static void PrintHello()
        {
            Console.WriteLine("Enter you name:");
            Console.WriteLine("Hello, " + Console.ReadLine());
        }
    }
}
