using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OneSystemToAnyOther
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base from which you want to convert");
            int baseFrom=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number that you want to convert");
            string number = Console.ReadLine();
            Console.WriteLine("enter the baseFrom to which you want to convert");
            int baseTo = int.Parse(Console.ReadLine());
            string decimalNumber=AnyToDecimal(number,baseFrom);
            string result = DecimalToAny(ulong.Parse(decimalNumber), baseTo);
            Console.WriteLine("The result is" + result);


        }
        static string AnyToDecimal(string number, int baseFrom)
        {
            number = number.ToUpper();



            ulong result = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int pom = 0;
                pom = HexaLetterToNumber(number[i]);
                result += (ulong)(Math.Pow(baseFrom, number.Length - 1 - i) * pom);
            }
            return result.ToString();

        }

        private static int HexaLetterToNumber(char number)
        {
            int pom = 0;
            switch (number)
            {
                case 'A':
                    {
                        pom = 10;
                        break;
                    }
                case 'B':
                    {
                        pom = 11;
                        break;
                    }
                case 'C':
                    {
                        pom = 12;
                        break;
                    }
                case 'D':
                    {
                        pom = 13;
                        break;
                    }
                case 'E':
                    {
                        pom = 14;
                        break;
                    }
                case 'F':
                    {
                        pom = 15;
                        break;
                    }
                default:
                    {
                        pom = int.Parse(number.ToString());
                        break;
                    }
            }
            return pom;
        }
        
        static string DecimalToAny(ulong number, int baseTo)
        {
           
            ulong remainder;
            string s = string.Empty;
            if (number == 0)
            {
                return "0";
            }
            while (number != 0)
            {
                remainder=number % (ulong)baseTo;
                number/=(ulong)baseTo;
                string pom = NumberToHexaLetter((int)remainder);
                s = pom+s;
                

            }
           return s.ToString();
        }
        private static string NumberToHexaLetter(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 10:
                    {
                        result = "A";
                        break;
                    }
                case 11:
                    {
                        result = "B";
                        break;
                    }
                case 12:
                    {
                        result = "C";
                        break;
                    }
                case 13:
                    {
                        result = "D";
                        break;
                    }
                case 14:
                    {
                        result = "E";
                        break;
                    }
                case 15:
                    {
                        result = "F";
                        break;
                    }

                default:
                    {
                        result = number.ToString();
                        break;
                    }


            }
            return result;
        }


    }
}
