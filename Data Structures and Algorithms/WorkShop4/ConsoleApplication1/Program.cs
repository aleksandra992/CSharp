using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRabbits
{
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            var rabbits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int tempRabbitCount = rabbits.Length - 1;
            int[] countRabbits = new int[1000001];


            for (var i = 0; i < rabbits.Length - 1; i++)
            {
                countRabbits[rabbits[i]] += 1;
            }

            BigInteger result = new BigInteger();
            for (var i = 0; i < countRabbits.Length; i++)
            {
                if (countRabbits[i] != 0)
                {
                    if (countRabbits[i] == 1)
                    {
                        result += i + 1;
                    }
                    else
                    {
                        result += (BigInteger)(i + 1) * (countRabbits[i] % (i + 1) == 0 ? countRabbits[i] / (i + 1) : countRabbits[i] / (i + 1) + 1);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
