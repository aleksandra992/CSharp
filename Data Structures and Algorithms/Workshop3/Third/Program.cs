using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }
                //Console.WriteLine(digit);
                a = a % b * 10;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int maxDenominator = int.Parse(Console.ReadLine());
            string fraction = Console.ReadLine().Split('.')[1];
            int bestNom = 0;
            int bestDen = 1;
            int precision = 0;
            for (var den = 1; den < maxDenominator; den++)
            {
                int left = 0;
                int right = den;
                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (Compare(fraction, middle, den))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
                int current = Divide(fraction, left, right);
                if (current > precision)
                {
                    bestDen = right;
                    bestNom = left;
                    precision = current;
                }
                current = Divide(fraction, left - 1, right);
                if (current > precision)
                {
                    bestDen = right;
                    bestNom = left - 1;
                    precision = current;
                }
                current = Divide(fraction, right, den);
                if (current > precision)
                {
                    bestDen = den;
                    bestNom = right;
                    precision = current;
                }
                current = Divide(fraction, right, den);
                if (current > precision)
                {
                    bestDen = den;
                    bestNom = right - 1;
                    precision = current;
                }
            }
            Console.WriteLine("{0}/{1}", bestNom, bestDen);
            Console.WriteLine(precision + 1);
        }

        static int Divide(string fraction, int a, int b)
        {
            a *= 10;
            int i = 0;
            for (; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }
                //Console.WriteLine(digit);
                a = a % b * 10;
            }
            return i;
        }


    }
}
