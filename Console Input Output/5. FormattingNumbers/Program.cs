using System;


namespace _5.FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b");
            float b = float.Parse(Console.ReadLine());
            Console.Write("enter c");
            float c = float.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2);
            Console.Write("{0,-10:X}|{1}|{2,10:0.##}|{3,-10:0.##} ",a,binary.PadLeft(10,'0'),b,c);

        }
    }
}
