using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MultiverseCommunication
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong result = 0;
            List<int> numbers = new List<int>();
            string str = Console.ReadLine();
            string[] digits = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };
            StringBuilder number = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                number.Append(str[i]);
                if (digits.Contains(number.ToString()))
                {
                    numbers.Add(Array.IndexOf(digits, number.ToString()));
                    number.Clear();
                }
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result +=(ulong) numbers[i] *(ulong) Math.Pow(13, numbers.Count -1- i);
            }
            Console.WriteLine(result);


        }
    }
}
