using System;


namespace _4.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter c=");
            int c = int.Parse(Console.ReadLine());
            string result = "";
            if (a == 0 || b == 0 || c == 0)
            {
                result = "0";
            }
            else

                if (  ((a > 0) && (b > 0) && (c > 0))  ||  ((a < 0) && (b < 0) && (c > 0))  ||  ((a < 0) && (b > 0) && (c < 0))  ||  ((a > 0) && (b < 0) && (c < 0)) )
                {
                    result = "+";
                }
                else
                    if (((a > 0) && (b > 0) && (c < 0)) || ((a > 0) && (b < 0) && (c > 0)) || ((a < 0) && (b > 0) && (c > 0)) || ((a < 0) && (b < 0) && (c < 0)))
                    {
                        result = "-";
                    }
            Console.WriteLine(result);
        }
    }
}
