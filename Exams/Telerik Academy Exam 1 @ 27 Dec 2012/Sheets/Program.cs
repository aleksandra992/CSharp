using System;

    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
           
            uint pom = 2047;

            string s = Convert.ToString(pom ^ n, 2).PadLeft(11,'0');
            string[] str = { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10" };

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    Console.WriteLine(str[i]);
                }
 
            }
        }
    }

