using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range");
            int range = int.Parse(Console.ReadLine());
            bool[] niza = new bool[range+1];
            niza[0] = true;
            niza[1]=true;
            for (int i = 2; i < niza.Length; i++)
            {
                for (int j = i; j*i < niza.Length; j++)
                {
                    niza[i*j] = true;
                }
            }
           Console.WriteLine(string.Join(",",niza.Select((val, ind) => new { Index = ind, Value = val })
                .Where(num => num.Value == false)
                .Select(num => num.Index.ToString())));
        }
    }
}
