using System;


namespace _7.Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("enter a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("enter b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("enter c=");
                double c = double.Parse(Console.ReadLine());
                double max = 0;
                if (a >= b)
                {
                    if (b >= c)
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                        max = a;
                    }
                    else if (a >= c)
                        Console.WriteLine(a + " " + c + " " + b);
                    else 
                        Console.WriteLine(c+" "+a+" "+b);
                }
                else
                if (b>=a)
                {
                    if (a >= c)
                    {
                        Console.WriteLine(b +" "+a+" "+c);
                    }

                    else if (b >= c)
                    {
                        Console.WriteLine(b+" "+" "+c+" "+a);
                    }
                    else Console.WriteLine(c+" "+" "+b+" "+a);
                }
                
            }

        }
    }
}
