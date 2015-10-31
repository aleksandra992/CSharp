namespace ReverseNumbers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var stack = new Stack<int>();
            string input;
            Console.WriteLine("Enter numbers");
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                stack.Push(int.Parse(input));
            }

            Console.WriteLine("The reverse order of the numbers is");
            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
