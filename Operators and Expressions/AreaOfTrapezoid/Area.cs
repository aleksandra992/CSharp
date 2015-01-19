using System;


namespace AreaOfTrapezoid
{
    class Area
    {
        static void Main()
        {
            Console.WriteLine("Enter a,b and h of the trapezoid");
          float a=float.Parse(  Console.ReadLine());
            float b=float.Parse(Console.ReadLine());
            float h=float.Parse(Console.ReadLine());
            float area = (a + b) * h / 2;
            Console.WriteLine("The area is " + area);
        }
    }
}
