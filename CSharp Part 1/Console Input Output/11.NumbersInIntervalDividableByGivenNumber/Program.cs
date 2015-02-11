using System;


namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the start=");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the end");
            int end = int.Parse(Console.ReadLine());
            int flag = 1;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i+", ");
                    flag = 0;
                }

                
            }
            if (flag == 1)
            {
                Console.WriteLine("-");
            }
            
        }
    }
}
