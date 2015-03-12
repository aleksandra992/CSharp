using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5.HelpDoge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            int columns = sizes[1];
            int rows = sizes[0];
           BigInteger[,] matrix = new BigInteger[rows, columns];
            int[] koska = Console.ReadLine().Split(new char[] { ' ' }).Select(x => int.Parse(x)).ToArray();
            int Fx = koska[0];
            int Fy = koska[1];
          int numberEnemies=int.Parse(Console.ReadLine());
            List<Point> enemies = new List<Point>();
            for (int i = 0; i < numberEnemies; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var enemyX = int.Parse(line[0]);
                var enemyY = int.Parse(line[1]);

                matrix[enemyX, enemyY] = -1;
            
            }
            for (int i = 0; i <=Fy; i++)
            {
                if (matrix[0,i]==-1)
                {
                    break;
                }
                else
                matrix[0, i] = 1;
            }
            for (int i = 0; i <= Fx; i++)
            {
                if (matrix[i,0]==-1)
                {
                 
                    break;
                }
                else
                    matrix[i, 0] = 1;
            }
                for (int i = 1; i <= Fx; i++)
                {
                    for (int j = 1; j <=Fy; j++)
                    {
                        if(matrix[i,j]==-1)
                        {
                            continue;
                        }
                        else
                            matrix[i, j] = ((matrix[i - 1, j]==-1)?0:(matrix[i-1,j])) + ((matrix[i, j - 1]==-1)?0:(matrix[i,j-1]));
                    }
                }

            Console.WriteLine(matrix[Fx,Fy]);
            
        }
    }
}
