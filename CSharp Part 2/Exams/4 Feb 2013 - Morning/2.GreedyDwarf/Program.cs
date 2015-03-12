using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.GreedyDwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valey = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>int.Parse(x)).ToArray();
            int[] originalValey = new int[valey.Length];
            Array.Copy(valey, originalValey, valey.Length);
            int visited = -2000;
            List<int[]> patterns = new List<int[]>();
            int numberOfPatterns = int.Parse(Console.ReadLine());
         
            for (int i = 0; i < numberOfPatterns; i++)
            {
                int[] pattern = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(x => int.Parse(x)).ToArray();
                patterns.Add(pattern);
            }
            BigInteger sum = new BigInteger();
            sum = 0;
            BigInteger maxSUm = new BigInteger();

            maxSUm = PatternSum(valey, patterns[0]);
         
                for (int i = 1; i < patterns.Count; i++)
                {
                    Array.Copy(originalValey, valey, originalValey.Length);
                    sum=PatternSum(valey ,patterns[i]);
                    if (sum > maxSUm)
                    {
                        maxSUm = sum;
                    }
             
                }
                Console.WriteLine(maxSUm);

        }

        private static BigInteger PatternSum(int[] valey, int[] pattern)
        {
            BigInteger sum = new BigInteger();
    
            sum = valey[0];
            valey[0] = -2000;
            uint previousIndex = 0;
           int j = 0;
            while (true)
            {
                j = j % pattern.Length;

                if ((previousIndex + pattern[j]) >= (valey.Length) || (previousIndex + pattern[j])<=0 || valey[previousIndex + pattern[j]] == -2000)
                {
                    break;
                }
                sum += valey[previousIndex + pattern[j]];
                valey[previousIndex + pattern[j]] = -2000;
                previousIndex = (uint)(previousIndex + pattern[j]);
                j++;

            }
            return sum;
        }
    }
}
