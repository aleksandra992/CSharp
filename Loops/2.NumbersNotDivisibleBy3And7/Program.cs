using System;



    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write(i + " ");

 
                }
            }

        }
    }

