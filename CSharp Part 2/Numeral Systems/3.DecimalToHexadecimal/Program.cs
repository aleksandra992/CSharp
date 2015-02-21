using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number n");
            int n = int.Parse(Console.ReadLine());
            string remainder="";
            List<string> list = new List<string>();
            while (n != 0)
            {
                remainder =( n % 16).ToString();
                n /= 16;
                switch (remainder)
                {
                    case "10":
                        {
                            remainder = "A";
                            break;
                        }
                    case "11":
                        {
                            remainder = "B";
                            break;
                        }
                    case "12":
                        {
                            remainder = "C";
                            break;
                        }
                    case "13":
                        {
                            remainder = "D";
                            break;
                        }
                    case "14":
                        {
                            remainder = "E";
                            break;
                        }
                    case "15":
                        {
                            remainder = "F";
                            break;
                        }
                        
                    default:
                        {
                            break;
                        }


                }
                list.Add(remainder);
                list.Reverse();
               

            }
            Console.WriteLine(string.Join("", list));
            Console.ReadKey();
        }
    }
}
