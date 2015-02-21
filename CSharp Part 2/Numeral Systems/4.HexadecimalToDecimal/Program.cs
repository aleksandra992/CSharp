using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter hexadecimal number");
            string hexa = Console.ReadLine().ToUpper();
            int result = 0;
            int number = 0;
            for (int i = hexa.Length - 1; i >= 0; i--)
            {
               
                switch (hexa[i])
                {
                        
                    case 'A':
                        {
                            number = 10;
                            break;
                        }
                    case 'B':
                        {
                            number = 11;
                            break;
                        }
                    case 'C':
                        {
                            number = 12;
                            break;
                        }
                    case 'D':
                        {
                            number = 13;
                            break;
                        }
                    case 'E':
                        {
                            number = 14;
                            break;
                        }
                    case 'F':
                        {
                            number = 15;
                            break;
                        }
                   
                    default:
                        {
                            number = int.Parse(hexa[i].ToString());
                            break;
                        }


                }

                result += number*(int)Math.Pow(16,hexa.Length-1-i);

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
