namespace TrieWordCounter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Counting words...");
            DateTime startAt = DateTime.Now;
            TrieNode root = new TrieNode(null, '?');
            Dictionary<DataReader, Thread> readers = new Dictionary<DataReader, Thread>();
            string path = "../../TextFiles/test.txt";
            DataReader newReader = new DataReader(path, ref root);
            newReader.ReadTrie();

            var words = new StreamReader(path).ReadToEnd().Split(new char[] { ',', ' ', '\r', '\n', '\t', '.', '?', '!', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Word {0}-{1} times",words[i],root.GetCount(words[i], 0));
            }

        }
    }
}
