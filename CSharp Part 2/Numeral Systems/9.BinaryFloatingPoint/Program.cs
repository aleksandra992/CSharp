using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.BinaryFloatingPoint
{
    class Program
    {

        static private int _bias;               

        public const int constant = 127;
        static ArrayList value = new ArrayList();
        static ArrayList biasBinary = new ArrayList();


        static public void Exponent(float number)
        {
            if (number < 0)
                number -= number;
            int newNumber = Convert.ToInt32(Math.Truncate(Math.Log(number, 2)));
            _bias = newNumber + constant;
            string biasNumber = Convert.ToString(_bias, 2);
            biasBinary.Add(biasNumber);
            Console.Write(" {0} ", biasBinary[0]);
        }


        static public void Mantisa(float number)
        {
            int integerPart = (int)number;
            Single decimalPart = number - integerPart;

            int integer;

            for (int i = 0; i < 23; i++)
            {
                Single result = decimalPart * 2;
                integer = (int)result;
                value.Add(integer);
                decimalPart = result - integer;
                Console.Write("{0}", value[i]);
            }
            Console.WriteLine();
        }

        static public void Sign(float number)
        {
            if (number > 0)
                Console.Write("0");
            else
                Console.Write("1");
        }



        static void Main()
        {
            float number = float.Parse(Console.ReadLine());
            Sign(number);
            Exponent(number);
            Mantisa(number);
        }
    }
}