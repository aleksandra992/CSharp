namespace HashSetImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var set = new HashedSet<int>();

            for (int i = 1; i < 50; i++)
            {
                set.Add(i);
            }

            var otherSet = new HashedSet<int>();

            for (int i = 50; i < 100; i++)
            {
                otherSet.Add(i);
            }

            Console.WriteLine(set.Find(7));
            Console.WriteLine("------------");
            Console.WriteLine(otherSet.Find(7));
            Console.WriteLine("------------");
            Console.WriteLine(set);
            Console.WriteLine("------------");
            Console.WriteLine(otherSet);
            Console.WriteLine("------------");
            Console.WriteLine(otherSet.Count);
            Console.WriteLine("------------");
            Console.WriteLine(set.Union(otherSet));
        }
    }
}
