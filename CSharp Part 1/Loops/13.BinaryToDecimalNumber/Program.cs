using System;

    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine().Trim();
            ulong d = 0;
            string a;
            char p;
            for (int i =s.Length-1; i>=0; i--)
            {

                p = s[i];
                if (p =='1')
                {
                    d += (ulong)(Math.Pow(2,s.Length-1-i));

                }
               
            }
           // Console.WriteLine(Convert.ToInt32(s, 2));
            Console.WriteLine(d);

        }
    }

