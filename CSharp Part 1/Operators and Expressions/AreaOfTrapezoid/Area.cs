using System;


namespace AreaOfTrapezoid
{
    class Area
    {
        static void Main()
        {
            Console.WriteLine("Enter a");
          float a=float.Parse(  Console.ReadLine());
          Console.WriteLine("Enter b");
            float b=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter h");
            float h=float.Parse(Console.ReadLine());
            float area = (a + b) * h / 2;
            Console.WriteLine("The area is " + area);
        }
    }
}
