using System;


namespace _10.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number n:");
            int number=int.Parse(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third=0;
            Console.Write(first+", ");
            Console.Write(second+", ");
            for (int i = 0; i < number-2; i++)
            {
                third=first+second;
                Console.Write(third+", ");
                first = second;

                second = third;
            }

        }
    }
}
