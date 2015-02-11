using System;


    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            decimal devisionAB =  ((decimal)a)/b;
            decimal devisionCD = ((decimal)c) / d;
            decimal result=devisionAB+devisionCD;
            
            if ((int)result != 0)
            {
                Console.WriteLine((int)result);
            }
            else
            {
                Console.WriteLine("{0:0.0000000000000000000000}", result);
            }
            long up = 0, down = 0;
            down = b * d;
            up = (down / b) * a + (down / d) * c;
            Console.WriteLine("{0}/{1}", up, down);
            

        }
       
    }

