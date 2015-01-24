using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a four digit number : ");
            string s = Console.ReadLine();
            while (s[0] == '0' || s.Length!=4)
            {
                Console.Write("Enter a four digit number that doesn't start with 0 : ");
                s = Console.ReadLine();
            }
            int n = int.Parse(s);
            int a = (n / 1000);
            int b = (n % 1000 / 100);
            int c = (n % 1000 % 100 / 10);
            int d = (n % 1000 % 100 % 10);

            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d * 1000 + c * 100 + b * 10 + a);
            Console.WriteLine(d * 1000 + a * 100 + b * 10 + c);
            Console.WriteLine(a * 1000 + c * 100 + b * 10 + d);
        }
    }

