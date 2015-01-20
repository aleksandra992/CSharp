using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            float thirdNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("the sum is:{0}", firstNumber + secondNumber + thirdNumber);
        }
    }

