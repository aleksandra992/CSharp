using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlappyBird
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Bird b = new Bird();
            b.Y = Console.WindowHeight / 2;
            b.X = 15;
            Obstacle downObstacle1=new Obstacle();
            Obstacle downObstacle2=new Obstacle();
            Obstacle downObstacle3=new Obstacle();
            Obstacle downObstacle4=new Obstacle();
            downObstacle1.height=8;
            downObstacle2.height=10;
            downObstacle3.height=10;
            downObstacle4.height=14;

            downObstacle1.X=20;
            downObstacle2.X=40;
            downObstacle3.X=70;
            downObstacle4.X=85;

             downObstacle1.Y=Console.WindowHeight-downObstacle1.height;
            downObstacle2.Y=Console.WindowHeight-downObstacle2.height;
            downObstacle3.Y=Console.WindowHeight-downObstacle3.height;
            downObstacle4.Y=Console.WindowHeight-downObstacle4.height;

            List<Obstacle> downObstacles=new List<Obstacle>();
            downObstacles.Add(downObstacle1);
            downObstacles.Add(downObstacle2);
            downObstacles.Add(downObstacle3);
            downObstacles.Add(downObstacle4);

            Obstacle upObstacle1=new Obstacle();
             Obstacle upObstacle2=new Obstacle();
             Obstacle upObstacle3=new Obstacle();
             Obstacle upObstacle4=new Obstacle();

            upObstacle1.height=10;
            upObstacle2.height=8;
            upObstacle3.height=8;
            upObstacle4.height=4;
            upObstacle1.X = 20;
            upObstacle2.X = 40;
            upObstacle3.X = 70;
            upObstacle4.X = 85;
            upObstacle1.Y = 0;
            upObstacle2.Y = 0;
            upObstacle3.Y = 0;
            upObstacle4.Y = 0;
            List<Obstacle> upObstacles = new List<Obstacle>();
            upObstacles.Add(upObstacle1);
            upObstacles.Add(upObstacle2);
            upObstacles.Add(upObstacle3);
            upObstacles.Add(upObstacle4);

            Boundaries bnd = new Boundaries();
            bnd.height = 25 ;
            bnd.leftX = 2;
            bnd.leftY = 0;
            bnd.rightX = 75;
            bnd.rightY = 0;
          
          while (true)
          {

              ReDraw(b,upObstacles, downObstacles,bnd);
              if (b.Y <= 0 || b.Y+4 >= Console.WindowHeight)
              {
                  Console.Clear();
                  Console.Write("Game over");
                  return;
              }
              if (Console.KeyAvailable)
              {
                  ConsoleKeyInfo firstPressedKey = Console.ReadKey(true);
                  if (firstPressedKey.Key == ConsoleKey.UpArrow)
                  {
                      b.Y-=2;
                  }

                  
              }
              b.Y++;
              Thread.Sleep(100);
              Console.Clear();
              
             
          }
          
        }
        static void ReDrawObstacles(List<Obstacle> upObstacles,List<Obstacle>downObstacles,Boundaries b)
        {
            int downStartY = 0, upStartY = 0;
           
          
            for (int i = 0; i < downObstacles.Count; i++)
            {
                if (downObstacles[i].X <= b.leftX)
                {
                    downObstacles.Remove(downObstacles[i]);
                }
                if (downObstacles.Count == 0)
                {
                    break;
                }
                downStartY = downObstacles[i].Y;
                for (int j = 0; j < downObstacles[i].height; j++)
                {
                    if (downObstacles[i].X+12 <= b.rightX)
                    {
                        if (j < 4)
                        {
                            PrintOnScreen(downObstacles[i].X, downObstacles[i].Y, downObstacles[i].upperPart[j], ConsoleColor.Red);

                        }
                        else
                            PrintOnScreen(downObstacles[i].X, downObstacles[i].Y, " |        |", ConsoleColor.Red);
                    }
                    downObstacles[i].Y++;

                }
                downObstacles[i].Y = downStartY;
                downObstacles[i].X--;
            }
            int k = 0;
            for (int i = 0; i < upObstacles.Count; i++)
            {
                if (upObstacles[i].X <= b.leftX)
                {
                    upObstacles.Remove(upObstacles[i]);
                }
                if (upObstacles.Count == 0)
                {
                    break;
                }
                upStartY = upObstacles[i].Y;
                k = 0;
                for (int j = 0; j < upObstacles[i].height; j++)
                {
                    if (upObstacles[i].X+12<= b.rightX)
                    {
                        if (j < upObstacles[i].height - 4)
                        {
                            PrintOnScreen(upObstacles[i].X, upObstacles[i].Y, " |        |", ConsoleColor.Red);


                        }
                        else
                        {
                            PrintOnScreen(upObstacles[i].X, upObstacles[i].Y, upObstacles[i].upperPart[k], ConsoleColor.Red);
                            k++;
                        }
                    }
                    upObstacles[i].Y++;

                }
                upObstacles[i].Y = upStartY;
                upObstacles[i].X--;
            }
           
        }
        static void PrintOnScreen(int x, int y, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void ReDrawBird(Bird b)
        {
            int birdStartY = 0;
            birdStartY = b.Y;
            for (int i = 0; i < b.bird.Length; i++)
            {

                PrintOnScreen(b.X, b.Y, b.bird[i], ConsoleColor.Yellow);
                b.Y++;
            }
            b.Y = birdStartY;
        }
        static void ReDrawBoundaries(Boundaries b)
        {
            int startLeftY = b.leftY;
            int startRightY = b.rightY;
            for (int i = 0; i < b.height; i++)
            {

                PrintOnScreen(b.leftX,b.leftY,"|", ConsoleColor.Black);
                PrintOnScreen(b.rightX, b.rightY, "|", ConsoleColor.White);
                b.leftY++;
                b.rightY++;
            }
            b.rightY = startRightY;
            b.leftY = startLeftY;
        }
        static void ReDraw(Bird b, List<Obstacle> upObstacles, List<Obstacle> downObstacles,Boundaries bnd)
        {
            ReDrawBird(b);
            ReDrawObstacles(upObstacles, downObstacles,bnd);
            ReDrawBoundaries(bnd);
        }
    }
}
