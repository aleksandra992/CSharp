using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the binary number");
            string s = Console.ReadLine();
            
            int padLeftToFour = 4 - (s.Length % 4);

            char[] pom = s.PadLeft(s.Length+padLeftToFour,'0').ToCharArray();
            Array.Reverse(pom);
            int pomNumber = 0;
            int k = 0;
            List<int> number = new List<int>();
           StringBuilder numberWithLetters=new StringBuilder();
            for (int i = 0; i<pom.Length; i++)
            {
                pomNumber += int.Parse(pom[i].ToString())*(int)Math.Pow(2, k);
                
                
                if (k == 3)
                {
                    number.Add(pomNumber);
                    pomNumber = 0;
                    k = 0;
                }
                else
                k++;
            }
            for (int i = 0; i < number.Count; i++)
            {
                switch (number[i])
                {
                    case 10:
                        {
                            numberWithLetters.Append("A");
                            break;
                        }
                    case 11:
                        {
                            numberWithLetters.Append( "B");
                            break;
                        }
                    case 12:
                        {
                            numberWithLetters.Append( "C");
                            break;
                        }
                    case 13:
                        {
                            numberWithLetters.Append("D");
                            break;
                        }
                    case 14:
                        {
                            numberWithLetters.Append("E");
                            break;
                        }
                    case 15:
                        {
                            numberWithLetters.Append("F");
                            break;
                        }
                    default:
                        {
                            numberWithLetters.Append(number[i].ToString());
                            break;

                        }
                }
            }
            pom = numberWithLetters.ToString().ToCharArray();
            Array.Reverse(pom);
                Console.WriteLine(string.Join("", pom));
            Console.ReadKey();

        }
    }
}
