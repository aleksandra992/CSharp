using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int[] niza = new int[20];
            for (int i = 0; i < niza.Length; i++)
            {


                niza[i] = i * 5;
            }
            Console.WriteLine(string.Join(",", niza));
            Console.ReadKey();
        }
    }

