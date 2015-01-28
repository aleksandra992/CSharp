using System;

    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
                string s=number.ToString();
                long sumEven = 0, sumOdd = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (char.IsDigit(s[i]))
                {
                    if (s[i] % 2 == 0)
                    {
                        sumEven +=long.Parse(s[i].ToString());
                    }
                    else
                        if (s[i] % 2 != 0)
                        {
                            sumOdd += long.Parse(s[i].ToString());

                        }
                }

            }
            if (sumEven > sumOdd)
            {
                Console.WriteLine("right "+sumEven);
            }
            else if (sumEven < sumOdd)
            {
                Console.WriteLine("left "+sumOdd);
            }
            else
                Console.WriteLine("straight "+sumEven);
        }
    }

