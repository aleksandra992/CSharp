using System;
using System.Collections.Generic;
using System.Linq;
namespace Dictionaries_Hash_Tables_and_Sets
{
    public class Startup
    {
        public static void Main()
        {
            var doubles = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var occurences = new Dictionary<double, int>();
            foreach (var num in doubles)
            {
                if (!occurences.ContainsKey(num))
                {
                    occurences[num] = 1;
                }
                else
                {
                    occurences[num]++;
                }
            }

            foreach(var pair in occurences)
            {
                Console.WriteLine("Value {0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
