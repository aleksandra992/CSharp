using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number");
            string n = Console.ReadLine();
            Console.Write("Enter the second number");
            string n1 = Console.ReadLine();
            Console.WriteLine(string.Join("", AddIntegers(n, n1)));
            Console.ReadKey();
        }
        static List<int> AddIntegers(string num1, string num2)
        {
            char[] n1 = num1.ToCharArray();
          

            char[] n2 = num2.ToCharArray();
            


            int length = 0;
            List<int> result = new List<int>();
            if (n1.Length < n2.Length)
            {
                length = n1.Length;
            }
            else
                length = n2.Length;
            int i;
            int sumDigits = 0;
            int remainder = 0;
            int devision = 0;
            int sum = 0;
            for (i = 0; i < length; i++)
            {
                

                sum = int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString())+devision;
                remainder = sum % 10;
                result.Add((char)(remainder));
                devision = sum / 10;


            }

            
            while (i < n1.Length)
            {


                sum = int.Parse(n1[i].ToString()) + devision;
               
                remainder = sum % 10;
                result.Add(remainder);
                devision = sum / 10;
                i++;

            }

            while (i < n2.Length)
            {
                sum = int.Parse(n2[i].ToString()) + devision;
                
                remainder = sum % 10;
                result.Add(remainder);
                devision = sum / 10;
                i++;
            }
            if (devision != 0)
            {
                result.Add(devision);
            }


            result.Reverse();
            return result;
        }
    }
}
