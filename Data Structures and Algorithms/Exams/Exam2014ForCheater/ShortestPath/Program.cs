namespace ConsoleApplication1
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {

            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] numOfSeates = new int[n];
            for (var i = 0; i < n; i++)
            {
                numOfSeates[i] = int.Parse(Console.ReadLine());
            }
            int[] sums = new int[100000+1];
            for (var i = 0; i < numOfSeates.Length; i++)
            {
                sums[numOfSeates[i]] += 1;
            }
            for (var i = 0; i < sums.Length; i++)
            {
                if (sums[i] == 0)
                {
                    continue;
                }
                for (var j = 0; j < numOfSeates.Length; j++)
                {
                    if (sums[i + numOfSeates[j]] == 0 || sums[i + numOfSeates[j]] > sums[i] + 1)
                    {
                        sums[i + numOfSeates[j]] += 1;
                    }
                }
            }

            for (var i = k; i < sums.Length; i++)
            {

            }


        }
    }
}
