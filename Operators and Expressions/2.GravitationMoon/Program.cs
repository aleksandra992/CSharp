using System;


namespace _2.GravitationMoon
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the weight on Earth : ");
            double weightEarth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(17 * (weightEarth / 100));
        }
    }
}
