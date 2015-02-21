using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static List<int> MultipleIntegers(char[] num1, char[] num2)
        {

            Array.Reverse(num1);
            Array.Reverse(num2);
            List<List<string>> results = new List<List<string>>();
            int k = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    int product = num1[i] * num2[j];
                    int devision = product / 10;
                    int remainder = product % 10;
                    results[k].Add((remainder + devision).ToString());

                }
                k++;
            }


                return results;
        }

        static List<int> AddIntegers(List<char[]> s)
        {
            
            foreach (var item in s)
            {
                Array.Reverse(item);                
            }


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

                sum = int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString());

                devision = sum / 10;
                remainder = sum % 10;
                result.Add((char)(remainder + devision));

            }
            while (i < n1.Length)
            {


                sum = int.Parse(n1[i].ToString()) + devision;
                devision = sum / 10;
                remainder = sum % 10;
                result.Add(remainder + devision);
                i++;

            }
            while (i < n2.Length)
            {
                sum = int.Parse(n2[i].ToString()) + devision;
                devision = sum / 10;
                remainder = sum % 10;
                result.Add(remainder + devision);
                i++;
            }

            result.Reverse();
            return result;
        }
    }
}
