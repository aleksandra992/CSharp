using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.DurankulakNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] symbols = new string[168];
            List<int> numbers = new List<int>();
            for (int i = 0; i < 168; i++)
            {
                if (i < 26)
                {
                    symbols[i] = ((char)(i + 65)).ToString();
                }
                else
                {
                    symbols[i] = ((char)((i / 26) - 1 + 97)).ToString() + ((char)(i % 26 + 65)).ToString();
                }
            }
            StringBuilder str = new StringBuilder();
         
            for (int i = 0; i < input.Length; i++)
            {
                str.Append(input[i]);

                if (Array.IndexOf(symbols, str.ToString()) != -1)
                {
                    numbers.Add(Array.IndexOf(symbols, str.ToString()));
                    str.Clear();
                   
                    
                }
                
               

            }
            //if (str.Length != 0)
            //{
            //    numbers.Add(Array.IndexOf(symbols, str.ToString()));
            //}
            BigInteger result = new BigInteger();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result +=(BigInteger)( numbers[i] * Math.Pow(168, numbers.Count - 1 - i));
            }

            Console.WriteLine(result);
        }
    }
}
