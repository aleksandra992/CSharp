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
            //down obstacles
            

            List<Obstacle> downObstacles=new List<Obstacle>();
             List<Obstacle> upObstacles = new List<Obstacle>();
             int j = 4;
             int pom = 0;
            for (int i = 0; i < 30; i++)
            {
                if (i < 20)
                {
                    downObstacles.Add(new Obstacle(j + 1, (i * 40) + i, Console.WindowHeight - (j + 1)));
                    upObstacles.Add(new Obstacle(j + 1, (i * 40) + i, 0));
                    j++;
                }
                else
                    if (i >= 20 && i < 25)
                    {
                        downObstacles.Add(new Obstacle(j + 1, (i * 40) + i, Console.WindowHeight - (j + 1)));
                        upObstacles.Add(new Obstacle(j + 1, (i * 40) + i, 0));
                        pom = j + 1 ;
                        

                    }
                    else
                    {
                        
                        downObstacles.Add(new Obstacle(pom + 1, (i * 40) + i, Console.WindowHeight - (pom + 1)));
                        upObstacles.Add(new Obstacle(pom + 1, (i * 40) + i, 0));
                    }
                
                

            }
               
            
            

            Boundaries bnd = new Boundaries();
            bnd.height = Console.WindowHeight ;
            bnd.leftX = 2;
            bnd.leftY = 0;
            bnd.rightX = 75;
            bnd.rightY = 0;
          
          while (true)
          {
              if (upObstacles.Count == 0 && downObstacles.Count == 0)
              {
                  Console.WriteLine("Finish,you got all 100 points");
                  Thread.Sleep(1000);
                  return;
 
              }
              if (Console.KeyAvailable)
              {
                  ConsoleKeyInfo firstPressedKey = Console.ReadKey(true);
                  if (firstPressedKey.Key == ConsoleKey.UpArrow)
                  {
                      b.Y -= 2;
                  }


              }

              b.Y++;

              ReDraw(b,upObstacles, downObstacles,bnd);
              if (b.Y <= 0 || b.Y+4 >= Console.WindowHeight)
              {
                  Console.Clear();
                  Console.Write("Game over");
                  return;
                  
              }
             
             
              for (int i = 0; i < downObstacles.Count; i++)
              {
                  if (b.Y + b.bird.Length-1 >= downObstacles[i].Y && b.X + b.bird.Length-1 >= downObstacles[i].X)
                  {
                      Console.Clear();
                      Console.WriteLine("Game over");
                      return;
                  }
              }
              for (int i = 0; i < upObstacles.Count; i++)
              {
                  if (b.Y+1 <= upObstacles[i].Y + upObstacles[i].height && b.X + b.bird.Length-1 >= upObstacles[i].X)
                  {
                      Console.Clear();
                      Console.WriteLine("Game over");
                      return;
                  }
              }
         
              Thread.Sleep(30);
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
                downObstacles[i].X-=3;
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
                upObstacles[i].X-=3;
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
