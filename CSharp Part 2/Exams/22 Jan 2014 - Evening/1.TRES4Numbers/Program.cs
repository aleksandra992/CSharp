using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.TRES4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] signs={"LON+","VK-","*ACAD","^MIM","ERIK|","SEY&","EMY>>","/TEL","<<DON"};
            ulong input = ulong.Parse(Console.ReadLine());
           
            StringBuilder output=new StringBuilder();
            List<int> numbers = new List<int>();

            if(input==0)
            {
                Console.Write(signs[0]);
                return;
            }
           ulong remainder = 0;
            while (input != 0)
            {
                remainder =(ulong) input % 9;
                numbers.Add((int)remainder);
                input /= 9;

            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                output.Append(signs[numbers[i]]);
            }
            Console.WriteLine(output.ToString());
        }
    }
}
