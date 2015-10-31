using System;
using System.Collections.Generic;

namespace QueueSequence
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Enter number n");
            int number = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(number);
            var sequence = new List<int>();
            sequence.Add(number);

            for (var i = 0; i < 50; i++)
            {
                var current = queue.Dequeue();
                sequence.Add(current + 1);
                queue.Enqueue(current + 1);
                sequence.Add(2 * current + 1);
                queue.Enqueue(2 * current + 1);
                sequence.Add(current + 2);
                queue.Enqueue(current + 2);

            }

            Console.WriteLine("The sequence is {0} ", string.Join(" ", sequence));
        }
    }
}
