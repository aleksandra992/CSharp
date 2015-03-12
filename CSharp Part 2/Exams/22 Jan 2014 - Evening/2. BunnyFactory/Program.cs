using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            StringBuilder result = new StringBuilder();
            string str = string.Empty;
            while (true)
            {

                if ((str = Console.ReadLine()) == "END")
                {
                    break;
                }
                else
                    numbers.Add(int.Parse(str));
            }

            int numberIterations = 1;
            int s = 0;
            int i = 0;
            ulong sum = 0;
            BigInteger product = new BigInteger();
            product = 1;
          
            while (true)
            {
                if (numberIterations > numbers.Count)
                {
                    break;
                }
                for (i = 0; i < numberIterations; i++)
                {
                    s += int.Parse(numbers[i].ToString());
                }
                if (s > numbers.Count - numberIterations)
                {
                    break;
                }
                int k;
                for (k = i; k < s + i; k++)
                {
                    sum += ulong.Parse(numbers[k].ToString());
                    product *= BigInteger.Parse(numbers[k].ToString());
                }
                result.Append(sum);

                result.Append(product);
                for (int h = k; h < numbers.Count; h++)
                {
                    result.Append(numbers[h]);
                }

                numbers = result.ToString().Where(x=>x!='0'&& x!='1').Select(x => int.Parse(x.ToString())).ToList();
                result.Clear();
                numberIterations++;
                s = 0;
                sum = 0;
                product = 1;
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}