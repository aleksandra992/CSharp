using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableLengthCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToList();
            int numberOfSymbols=int.Parse(Console.ReadLine());
            int[] symbols = new int[255];
            string s=string.Empty;
            for (int i = 0; i < numberOfSymbols; i++)
            {
                s=Console.ReadLine();
                symbols[s[0]] = int.Parse(s.Substring(1));
            }
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0; i < numbers.Count; i++)
            {
                encodedText.Append(Convert.ToString(numbers[i], 2).PadLeft(8,'0'));
            }
            StringBuilder result = new StringBuilder();
            int br = 0;
            for (int i = 0; i < encodedText.Length; i++)
            {
                if (encodedText[i] == '1')
                {
                    br++;
                    
                }
                else
                {
                    result.Append((char)Array.IndexOf(symbols,br));
                    br = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
}
