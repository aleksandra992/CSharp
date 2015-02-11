using System;
using System.Globalization;
using System.Threading;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());
            decimal inMachine = n1 * 0.05M+n2*0.10M+n3*0.20M+n4*0.50M+n5*1M;
            decimal change=amount-price;
            if (change >= 0 && inMachine >= (change))
            {
                
                Console.WriteLine("Yes {0:0.00}", inMachine - (amount - price));
                
            }
            else
                if (price > amount)
                {
                    Console.WriteLine("More {0:0.00}", price - amount);
                }
                else
                    if (change > 0 && inMachine < change)
                    {
                        Console.WriteLine("No {0:0.00}", change - inMachine);
                    }
            

        }
    }

