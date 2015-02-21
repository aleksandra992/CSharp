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
            List<int> nFac=new List<int>();
            nFac.Add(1);
            List<int> nFacNext = new List<int>();
            nFacNext=MultipleIntegerWithArray(new int[] { 6 }, 4);
            for (int i = 2; i < 100; i++)
            {
                nFacNext =new List<int>( MultipleIntegerWithArray(nFac.ToArray<int>(), i));
                Console.WriteLine(string.Join("", nFacNext.ToArray<int>()));
                nFac=new List<int>( nFacNext);
            }
            nFac.Add(0);
            nFac.Add(0);
            Console.WriteLine(string.Join("", nFac.ToArray<int>()));
           // MultipleIntegerWithArray(new int[]{1,2,3},33);

        }
        static List<int> MultipleIntegerWithArray(int[] num1, int number)
        {

            Array.Reverse(num1);
            List<int> result = new List<int>();
            List<int> results1 = new List<int>();
            List<int> results2 = new List<int>();
            int k = 0;
            int secondDigit;
            int devision = 0;
            int devision1 = 0;
            int product1 = 1;
            int product2 = 1;
            int remainder = 0;
            int firstDigit;
            for (int i = 0; i < num1.Length; i++)
            {

                secondDigit = number % 10;

                product1 = num1[i] * secondDigit + devision;
                remainder = product1 % 10;
                results1.Add((remainder));
                devision = product1 / 10;
                if (number / 10 != 0)
                {

                    firstDigit = number / 10;
                    product2 = num1[i] * firstDigit + devision1;
                    remainder = product2 % 10;
                    results2.Add((remainder));
                    devision1 = product2 / 10;
                }
            }
            if (devision != 0)
            {
                results1.Add(devision);
            }
            if (devision1 != 0)
            {
                results2.Add(devision1);
            }
                results1.Reverse();
                results2.Reverse();
                results2.Add(0);
                if (result.Count == 0)
                {
                    result = AddIntegers(results1, results2);
                }
                else
                    result = AddIntegers(result, AddIntegers(results1, results2));







                return result;
        }

        static List<int> AddIntegers(List<int> num1, List<int> num2)
        {

            num1 = num1.AsEnumerable().Reverse().ToList();

            num2 = num2.AsEnumerable().Reverse().ToList();
            int length = 0;
            List<int> result = new List<int>();
            if (num1.Count < num2.Count)
            {
                length = num1.Count;
            }
            else
                length = num2.Count;
            int i;
            int sumDigits = 0;
            int remainder = 0;
            int devision = 0;
            int sum = 0;
            for (i = 0; i < length; i++)
            {

                sum = num1[i] + num2[i] + devision;
                remainder = sum % 10;
                result.Add(remainder);
                devision = sum / 10;

            }

            while (i < num1.Count)
            {


                sum = num1[i] + devision;

                remainder = sum % 10;
                result.Add(remainder);
                devision = sum / 10;
                i++;

            }
            while (i < num2.Count)
            {
                sum = num2[i] + devision;

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
