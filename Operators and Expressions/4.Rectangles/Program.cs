using System;



    class Program
    {
        static void Main()
        {
            Console.Write("Enter width :");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter : " + ((2 * w) + (2 * h)));
            Console.WriteLine("Area : " + (w * h));
        }
    }

