using System;

namespace HashTableImplementation
{
    public class Startup
    {
        public static void Main()
        {
            var hashTable = new HashTable<int, int>();
            for (var i = 0; i < 50; i++)
            {
                hashTable.Add(i, i);
            }

            int value;
            hashTable.Find(5, out value);
            Console.WriteLine(value);

            hashTable.Remove(4);

            Console.WriteLine(hashTable.Count);

            Console.WriteLine(hashTable[5]);
            Console.WriteLine(string.Join(".", hashTable.Keys));
            foreach(var pair in hashTable)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}
