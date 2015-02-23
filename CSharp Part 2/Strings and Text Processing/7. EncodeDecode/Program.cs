using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EncodeDecode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter string that you want to encode");
            string str = Console.ReadLine();
            Console.WriteLine("enter the key");
            string key = Console.ReadLine();
          Console.WriteLine(  Encode(str, key));
          Console.WriteLine(Encode(Encode(str, key), key));

        }

        private static string Encode(string str, string key)
        {
            string result = string.Empty;

            string encrypted = string.Empty;
            int k=0;
            for (int i = 0; i < str.Length; i++)
            {
                

                result += (char)(str[i] ^ key[k]);
                k++;
                if (k == key.Length)
                {
                    k = 0;
                }

            }
            return result;
            
        }
       
    }
}
