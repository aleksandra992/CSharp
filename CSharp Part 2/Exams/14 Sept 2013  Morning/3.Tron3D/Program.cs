using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Tron3D
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).Select(x => int.Parse(x)).ToArray();
            int X = dimensions[0];
            int Y = dimensions[1];
            int Z = dimensions[2];
            string redDirections = Console.ReadLine();
            string blueDirections = Console.ReadLine();
            int[,] matrix = new int[X + 1, 2 * (Y + Z)];//red player puts 1 on the cells that he visit,blue player puts 2
            Position redPlayer = new Position(Y / 2, X / 2);
            Position bluePlayer = new Position(Y + Z + Z / 2, X / 2);
            Position startRedPlayer = new Position(Y / 2, X / 2);
            Position startBluePlayer = new Position(Y + Z + Z / 2, X / 2);
            int redDirection = 3;//0-up,1-down,2-right,3-left
            int blueDirection = 2;
            int red = 1;
            int blue = 2;
            bool redGameOver = false;
            bool blueGameOver = false;
            int r = 0;
            int b = 0;

            for (int i = 0; i < redDirections.Length; i++)
            {

                Visit(bluePlayer, matrix, blue);
                Visit(redPlayer, matrix, red);
                while (redDirections[r] != 'M' && r < blueDirections.Length)
                {
                    redDirection = Direction(redDirection, redDirections[i]);
                    r++;
                }
                Move(redDirection, redPlayer);
              

                //Visit(redPlayer,matrix, red);
                while (blueDirections[b] != 'M' && b < blueDirections.Length)
                {
                    blueDirection = Direction(blueDirection, blueDirections[i]);
                    b++;
                }
                Move(blueDirection, bluePlayer);
                // Visit(bluePlayer, matrix, blue);
                if (redPlayer.X < 0)
                {
                    redPlayer.X = 2 * (Y + Z) - 1;
                }
                if (redPlayer.X > 2 * (Y + Z) - 1)
                {
                    redPlayer.X = 0;
                }
                if (bluePlayer.X < 0)
                {
                    bluePlayer.X = 2 * (Y + Z) - 1; ;
                }
                if (bluePlayer.X > 2 * (Y + Z) - 1)
                {
                    bluePlayer.X = 0;
                }
                if (redPlayer.Y < 0 || redPlayer.Y > X || matrix[redPlayer.Y, redPlayer.X] != 0)
                {
                    redGameOver = true;
                }
                if (bluePlayer.Y < 0 || bluePlayer.Y > X || matrix[bluePlayer.Y, bluePlayer.X] != 0
                   )
                {
                    blueGameOver = true;
                }
                if (redGameOver == true && blueGameOver == true)
                {
                    Console.WriteLine("DRAW");
                    Console.WriteLine(Distance(startRedPlayer,redPlayer,X,Y,Z));
                 
                    return;
                }
                if (redGameOver == true && blueGameOver == false)
                {
                    Console.WriteLine("BLUE");
                    Console.WriteLine(Distance(startRedPlayer,redPlayer,X,Y,Z));
                   
                    return;
                }
                if (redGameOver == false && blueGameOver == true)
                {
                    Console.WriteLine("RED");
                    Console.WriteLine(Distance(startRedPlayer, redPlayer,X,Y,Z));
                    PrintMatrix(matrix);
                    return;
                }
            }





        }
        static int Direction(int previousDirection, char nextDirection)
        {
            switch (previousDirection)
            {
                case 0:
                    {
                        if (nextDirection == 'L')
                        {
                            return 3;
                        }
                        else
                            if (nextDirection == 'R')
                            {
                                return 2;
                            }
                            else
                                return 0;
                    }
                case 1:
                    {
                        if (nextDirection == 'L')
                        {
                            return 2;
                        }
                        else
                            if (nextDirection == 'R')
                            {
                                return 3;
                            }
                            else
                                return 1;
                    }
                case 2:
                    {
                        if (nextDirection == 'L')
                        {
                            return 0;
                        }
                        else
                            if (nextDirection == 'R')
                            {
                                return 1;
                            }
                            else
                                return 2;
                    }
                case 3:
                    {
                        if (nextDirection == 'L')
                        {
                            return 1;
                        }
                        else
                            if (nextDirection == 'R')
                            {
                                return 0;
                            }
                            else
                                return 3;
                    }
                default: return -1;
            }
        }
        static void Move(int position, Position player)
        {
            switch (position)
            {
                case 0:
                    {
                        player.Y--;
                        break;
                    }
                case 1:
                    {
                        player.Y++;
                        break;
                    }
                case 2:
                    {
                        player.X++;
                        break;
                    }
                case 3:
                    {
                        player.X--;
                        break;
                    }
                default: break;
            }


        }
        static void Visit(Position player, int[,] matrix, int redOrBlue)
        {

            matrix[player.Y, player.X] = redOrBlue;
        }
        static int Distance(Position start, Position end,int X,int Y,int Z)
        {
            int distance;
            int h = Math.Abs(start.Y - end.Y);
            int x = 0;
            if (Math.Abs(start.X - end.X) > 2 * (Y + Z) - Math.Abs(start.X - end.X))
            {
                
                x = 2 * (Y + Z) - Math.Abs(start.X - end.X); 
            }
            else
                x = Math.Abs(start.X - end.X);
            return h + x;
        }
        static  void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Position
    {
        public int X;
        public int Y;



        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;

        }
    }
}
