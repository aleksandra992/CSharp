using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Problem3
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] matrix = new int[rows, cols];
            int rowCounter = 0;
            int counter = -3;
            for (int col = 0; col < cols; col++)
            {
                counter += 3;
                rowCounter = counter;
                for (int row = rows - 1; row >= 0; row--)
                {

                    matrix[row, col] = rowCounter;
                    rowCounter += 3;
                }
            }
            int numberCommands = int.Parse(Console.ReadLine());
            List<Command> commands = new List<Command>();
            for (int i = 0; i < numberCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                commands.Add(new Command(command[0], int.Parse(command[1])));
            }
            int rowCat = rows - 1;
            int colCat = 0;
           
            
            BigInteger result = new BigInteger();
            result = 0;
            result += matrix[rowCat, colCat];
            matrix[rowCat, colCat] = 0;
           
            for (int i = 0; i < commands.Count; i++)
            {
                Command c = commands[i];


                for (int j = 0; j < c.moves - 1; j++)
                {

                    
                    if (c.direction == "RU" || c.direction == "UR")
                    {
                        colCat++;
                        rowCat--;
                    }
                    if (c.direction == "RD" || c.direction == "DR")
                    {
                        colCat++;
                        rowCat++;
                    }
                    if (c.direction == "DL" || c.direction == "LD")
                    {
                        colCat--;
                        rowCat++;
                    }
                    if (c.direction == "LU" || c.direction == "UL")
                    {
                        colCat--;
                        rowCat--;
                    }

                    if(colCat<0 && (c.direction=="LU" || c.direction=="UL"))
                    {
                      
                      colCat++;
                    rowCat++;
                    
                    }
                    if(colCat<0 && (c.direction=="DL" || c.direction=="LD"))
                    {
                        rowCat--;
                        colCat++;
                    }
                    if(colCat>cols-1&&(c.direction=="UR" || c.direction=="RU"))
                    {
                        rowCat++;
                        colCat--;
                    }
                    if(colCat>cols-1&&(c.direction=="DR" || c.direction=="RD"))
                    {
                        rowCat--;
                        colCat--;
                    }

                    if (rowCat < 0 && (c.direction == "LU" || c.direction == "UL"))
                    {
                        colCat++;
                        rowCat++;
                    }
                    if (rowCat < 0 && (c.direction == "RU" || c.direction == "UR"))
                    {
                        colCat--;
                        rowCat++;
                    }
                    if (rowCat > rows - 1 && (c.direction == "DR" || c.direction == "RD"))
                    {
                        rowCat--;
                        colCat--;
                    }
                   

                    if (rowCat >rows-1 && (c.direction == "DL" || c.direction == "LD"))
                    {
                        colCat++;
                        rowCat--;
                    }
                    result += matrix[rowCat, colCat];
                    matrix[rowCat, colCat] = 0;

                }

            }
            Console.WriteLine(result);


        }
        
    }
    class Command
    {
        public string direction;
        public int moves;

        public Command(string dir, int m)
        {
            this.direction = dir;
            this.moves = m;
        }
    }
}
    
