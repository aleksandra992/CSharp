using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Problem1
    {
        static void Main(string[] args)
        {

            char[] symbols = new char[23];
            for (int i = 0; i < 23; i++)
            {
                symbols[i] = (char)(i + 97);
            }

            string[] input = Console.ReadLine().Split(' ');
            List<ulong> numbers = new List<ulong>();
            for (int i = 0; i < input.Length; i++)
            {
                ulong number = 0;
                for (int j = input[i].Length-1; j >= 0; j--)
                {

                    number +=(ulong) Array.IndexOf(symbols, input[i][j]) *(ulong)Math.Pow(23, input[i].Length-1 - j);
                }
                numbers.Add(number);
           

            }
            ulong sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            ulong pomSum=sum;
            string s = string.Empty;
            if (sum == 0)
            {
                s = "a";
            }
            ulong remainder = 0;
         
            while (pomSum != 0)
            {
                remainder = pomSum % 23;
                s += symbols[remainder];
                pomSum /= 23;
            }
            char[]output=s.ToCharArray();
            Array.Reverse(output);
            s=new string(output);
            Console.WriteLine("{0} = {1}", s, sum);

        }
    }
}
