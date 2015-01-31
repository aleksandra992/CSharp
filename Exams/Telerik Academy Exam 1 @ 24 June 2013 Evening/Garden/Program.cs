using System;
using System.IO;

    class Program
    {
        static void Main()
        {
           // StreamReader reader=new StreamReader("..\\..\\sample-text.txt");
          //  Console.SetIn(reader);
            uint[] area=new uint[6];
            uint[] seedsAmount=new uint[6];
            uint totalArea=0;
            decimal[] prices = {0.5M,0.4M,0.25M,0.6M,0.3M,0.4M};
            decimal seedsCost = 0M;
            for(int i=0;i<5;i++)
            {
                seedsAmount[i] = uint.Parse(Console.ReadLine());
                area[i] = uint.Parse(Console.ReadLine());
                seedsCost += seedsAmount[i] * prices[i];
                totalArea += area[i];
            }
            
            seedsAmount[5] = uint.Parse(Console.ReadLine());
            seedsCost += seedsAmount[5] * prices[5];
            Console.WriteLine("Total costs: {0:0.00}", seedsCost);
            if (totalArea < 250)
            {
                Console.WriteLine("Beans area: {0}", 250 - totalArea);
            }
            else
            if(totalArea>250)
            {
                Console.WriteLine("Insufficient area");
            }
            else
                Console.WriteLine("No area for beans");


        }
    }

