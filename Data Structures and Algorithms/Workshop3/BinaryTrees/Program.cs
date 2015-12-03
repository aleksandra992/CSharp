namespace BinaryTrees
{
    using System;

    public class Program
    {
        static long[] memo;

        public static long Trees(int n)
        {
            long result = 0;
            if (n == 0)
            {
                return 1;
            }
            if (memo[n] > 0)
            {
                return memo[n];
            }

            for (int i = 0; i < n; i++)
            {
                result += Trees(i) * Trees(n - 1 - i);
            }
            memo[n] = result;
            return result;
        }

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var groups = new int[26];
            memo = new long[input.Length + 1];
            foreach (var ball in input)
            {
                groups[ball - 'A']++;
            }

            int n = input.Length;
            var factorials = new long[n + 1];
            factorials[0] = 1;
            for (var i = 0; i < n; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            long result = factorials[n];

            foreach (var x in groups)
            {
                result /= factorials[x];
            }
            Console.WriteLine(result * Trees(n));

        }
    }
}
