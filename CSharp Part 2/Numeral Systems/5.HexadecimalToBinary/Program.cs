using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter hexadecimal number");
            string hexa = Console.ReadLine();
            int number = 0;
            int remainder=0;

          StringBuilder oneDigit = new StringBuilder();
            List<string> binary = new List<string>();
            
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
                        }
                        break;
                        
                }
                
                while (number != 0)
                {
                    remainder = number % 2;
                    number /= 2;
                    oneDigit.Append( remainder);
                  
                    

                }



                string s = oneDigit.ToString().PadRight(4, '0');//ja tva tuka
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
               
                binary.Add(new string(charArray));
                oneDigit.Clear();
             
                
            }
            binary.Reverse();
            for (int i = 0; i < binary.Count; i++)
            {
                Console.Write(string.Join("",binary[i])+" ");
            }
           
            Console.ReadKey();
        }
    }
}
