using System;

    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int br=0;
            int sum=0;
            for (int i = 0; i < s.Length; i+=2)
            {
                if(char.IsDigit(s[i]))
                {
                    br++;
                    sum+=int.Parse(s[i].ToString());
                }
            }
            Console.WriteLine(br+" "+sum);
        }
    }

