using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            int SystemBase = 256;
            string[] digitsSystem = new string[SystemBase];
            string result = string.Empty;
            ulong number = ulong.Parse(Console.ReadLine());
            digitsSystem = GenerateNumberArray(SystemBase);
            int remainder = 0;
            if (number == 0)
            {
                result = "A";
            }
            while (number!= 0)
            {
                remainder = (int)(number % (ulong)SystemBase);
                number /= (ulong)SystemBase;
                result = digitsSystem[remainder]+result;

            }

            Console.WriteLine(result);
           

        }

        private static string[] GenerateNumberArray(int SystemBase)
        {
            string[] digitsSystem = new string[SystemBase];

            for (int i = 0; i < SystemBase; i++)
            {
                if (i < 26)
                    digitsSystem[i] = ((char)(i + 'A')).ToString();
                else
                {
                    digitsSystem[i] = ((char)(i / 26 - 1 + 'a')).ToString() + ((char)(i % 26 + 'A')).ToString();
                }

            }
            return digitsSystem;
        }
    }
}
