using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type\n1 --> int\n2 --> double\n3--> string");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.Write("please enter an integer:");
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine(integer + 1);
                        break;

                    }
                case 2:
                    {
                        Console.Write("please enter a double:");
                        double doubleNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine(doubleNumber + 1);
                        break;
 
                    }
                case 3:
                    {
                         Console.Write("please enter a string:");
                         string s = Console.ReadLine();
                        Console.WriteLine(s+"*");
                        break;
                    }
 
            }
        }
    }
}
