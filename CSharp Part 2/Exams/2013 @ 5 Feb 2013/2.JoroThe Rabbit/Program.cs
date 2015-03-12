using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.JoroThe_Rabbit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] terrain = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int br = 0;
           
            int lenght = 0;
            int MaxLenght = int.MinValue;
            for (int i = 0; i < terrain.Length; i++)
            {

                for (int step = 1; step < terrain.Length; step++)
                {
                    int j;
                    lenght = 1;
                    for ( j = i; true; j++)
                    {
                        if (j >= terrain.Length ||( j+step)>=terrain.Length)
                        {
                            if (terrain[j % terrain.Length] >= terrain[(j + step) % terrain.Length])
                            {
                                break;
                            }
                        }
                        else
                        {
                            if (terrain[j ] >= terrain[(j + step) ])
                            {
                                break;
                            }
                        }
                        lenght++;
                        j = j + step;
                        j--;

                    }
                    
                        if (lenght > MaxLenght)
                        {
                            MaxLenght = lenght;
                        }
                       
                    
                }
            }
           
            Console.WriteLine(MaxLenght);
        }
    }
}
