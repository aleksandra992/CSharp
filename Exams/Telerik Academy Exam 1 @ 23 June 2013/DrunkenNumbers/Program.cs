using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long countMitko = 0, countVladko = 0;
            int sredina = 0;
            string vlatkoString,mitkoString;
            for (int i=0; i < n; i++)
            {
                string number = Console.ReadLine().TrimStart(new char[]{'0','-'});
               if (number.Length % 2 == 0)
                {
                    sredina = number.Length / 2;
                }
                else
                sredina = (number.Length / 2)+1;
               mitkoString = number.Substring(0, sredina);
                vlatkoString = number.Substring((number.Length % 2 == 0) ? sredina : sredina-1,sredina);
                countMitko += SumNumbersString(mitkoString);
                countVladko += SumNumbersString(vlatkoString);

            }
            if (countMitko > countVladko)
            {
                Console.WriteLine("M {0}", countMitko-countVladko);
            }
            else if (countVladko > countMitko)
            {
                Console.WriteLine("V {0}", countVladko-countMitko);
            }
            else
                Console.WriteLine("No {0}", countMitko + countVladko);
        }
        static long SumNumbersString(string s)
        {
            long sum=0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += long.Parse(s[i].ToString());
            }
                return sum;
        }
    }


