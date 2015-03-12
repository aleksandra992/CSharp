using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.KaspichanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong s = ulong.Parse(Console.ReadLine());
            if (s == 0)
            {
                Console.WriteLine("A");
                return;
            }
            string[] symbols = new string[256];
            for (int i = 0; i < 256; i++)
            {
                if (i < 26)
                {
                    symbols[i] =((char)( 65 + i)).ToString();
                }
                else if (i >= 26)
                {
                    symbols[i] = ((char)((i / 26)-1 + 97)).ToString() +((char)((i % 26) + 65)).ToString();
                }

            }
            string result = string.Empty;
           int remainder = 0;
                while (s != 0)
                {
                    remainder =(int)((ulong) s % 256);
                    s /= 256;
                    result = symbols[remainder] + result;
                    
                }
                Console.WriteLine(result);
        }
    }
}
