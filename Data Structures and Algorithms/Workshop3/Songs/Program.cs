namespace Songs
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] first = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            for (var i = 0; i < n; i++)
            {
                int index1i = Array.IndexOf(first, i);
                int index2i = Array.IndexOf(second, i);
                for (var j = i + 1; j < -n; j++)
                {
                    int index1j = Array.IndexOf(first, i);
                    int index2j = Array.IndexOf(second, i);
                }
            }

        }
    }
}
