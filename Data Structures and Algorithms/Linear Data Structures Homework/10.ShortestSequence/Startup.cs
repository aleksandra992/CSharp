namespace _10.ShortestSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static object item;

        public static void Main()
        {
            Console.WriteLine("Enter n and m on a separate line");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Queue<QueueItem> queue = new Queue<QueueItem>();
            var item = new QueueItem();
            item.Value = n;
            item.Previous = null;
            queue.Enqueue(item);
            while (true)
            {
                var previous = queue.Dequeue();
                var firstItem = new QueueItem();
                firstItem.Value = previous.Value + 2;
                firstItem.Previous = previous;
                var secondItem = new QueueItem();
                secondItem.Previous = previous;
                secondItem.Value = previous.Value + 1;
                var thirdItem = new QueueItem();
                thirdItem.Value = previous.Value * 2;
                thirdItem.Previous = previous;
                queue.Enqueue(firstItem);
                queue.Enqueue(secondItem);
                queue.Enqueue(thirdItem);
                if (firstItem.Value == m)
                {
                    PrintResult(firstItem);
                    break;
                }

                if (secondItem.Value == m)
                {
                    PrintResult(secondItem);
                    break;
                }

                if (thirdItem.Value == m)
                {
                    PrintResult(thirdItem);
                    break;
                }
            }
        }

        public static void PrintResult(QueueItem item)
        {
            var result = new List<int>();
            while (item != null)
            {
                result.Add(item.Value);
                item = item.Previous;
            }

            result.Reverse();
            Console.WriteLine(string.Join("->", result));
        }
    }
}
