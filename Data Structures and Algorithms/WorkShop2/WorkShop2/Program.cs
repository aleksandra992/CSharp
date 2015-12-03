namespace WorkShop2
{
    using System;

    public class Program
    {
        public static Matrix PowMod(Matrix a, long p)
        {
            if (p == 1)
            {
                return a;
            }

            if (p % 2 == 1)
            {
                return new Matrix(PowMod(a, p - 1), a);
            }

            a = PowMod(a, p / 2);
            return new Matrix(a, a);
        }

        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var init = new Matrix(1, 1, 1, 0);

            Console.WriteLine(PowMod(init, n).Table[0, 1]);
        }
    }
}