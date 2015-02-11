using System;

    class Nightmare
    {
        static void Main()
        {
            string s = Console.ReadLine();
            long sum = 0;
            long br = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {

                    if (char.IsDigit(s[i]))
                    {
                        sum += long.Parse(s[i].ToString());
                        br++;
                    }
                }
            }
            Console.WriteLine("{0} {1}",br,sum);
        }
    }

