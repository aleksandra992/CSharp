using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlappyBird
{
    class Program
    {
        static public int points = 0;
        static void Main()
        {
            HighScore();
            Console.BufferWidth = Console.WindowWidth=150;
            Console.BufferHeight = Console.WindowHeight=41;
            Bird b = new Bird();
            b.position.Y = Console.WindowHeight / 2;
            b.position.X = 15;
            string hurtSound=@"hurt.wav";
            string jumpSound=@"jump.wav";
            //down obstacles
            
            
            List<Obstacle> downObstacles=new List<Obstacle>();
             List<Obstacle> upObstacles = new List<Obstacle>();
             int j = 4;
             int pom = 0;
             int pom1 = 0;
            for (int i = 1; i < 51; i++)
            {
                if (i < 11)
                {
                    AddObstacles(downObstacles, upObstacles, i, j);
                    j++;
                }
                else
                    if (i >= 11 && i < 26)
                    {

                        AddObstacles(downObstacles, upObstacles, i, j);
                        pom = j + 1 ;
                        

                    }
                    else
                        if (i >= 26 && i < 41)
                        {
                            AddObstacles(downObstacles, upObstacles, i, pom);

                            
                            pom1 = pom + 1;

                        }
                        else
                        {
                            AddObstacles(downObstacles, upObstacles, i, pom1);
                        }

                
                

            }
               
            
            

            Boundaries bnd = new Boundaries();
            bnd.height = Console.WindowHeight ;
            bnd.leftX = 2;
            bnd.leftY = 0;
            bnd.rightX = Console.BufferWidth-40;
            bnd.rightY = 0;
           
          while (true)
          {
              if (upObstacles.Count == 0 && downObstacles.Count == 0)
              {
                  PrintOnScreen(Console.BufferWidth - 35, 12, "Congratulations, you've got " + points, ConsoleColor.Yellow);
                  PrintOnScreen(Console.BufferWidth - 35, 14, "Restart the game Y/N", ConsoleColor.Yellow);
                  break;
 
              }
              if (Console.KeyAvailable)
              {
                  ConsoleKeyInfo firstPressedKey = Console.ReadKey(true);
                  if (firstPressedKey.Key == ConsoleKey.UpArrow)
                  {
                      b.position.Y -= 2;
                     PlaySound(jumpSound);
                  }


              }

              b.position.Y++;
           
              ReDraw(b,upObstacles, downObstacles,bnd);
              if (b.position.Y <= 0 || b.position.Y+4 >= Console.WindowHeight)
              {
                 // Console.Clear();
               // points= Score(upObstacles);
                 PlaySound(hurtSound);
                 WriteScoreInFile();
                 PrintGameOver();
                  break;
                  
              }

              bool hit = false;
              for (int i = 0; i < downObstacles.Count; i++)
              {
                  if (b.position.Y + b.bird.Length-1 >= downObstacles[i].Y && b.position.X + b.bird.Length-1 >= downObstacles[i].X)
                  {
                    //  Console.Clear();
                    //  points = Score(upObstacles);
                     PlaySound(hurtSound);
                     WriteScoreInFile();
                     PrintGameOver();
                      hit = true;
                      break;
                  }
              }
              if (hit)
                  break;
              for (int i = 0; i < upObstacles.Count; i++)
              {
                  if (b.position.Y+1 <= upObstacles[i].Y + upObstacles[i].height && b.position.X + b.bird.Length-1 >= upObstacles[i].X)
                  {
                     // Console.Clear();
                   //   points = Score(upObstacles);
                      PlaySound(hurtSound);
                      WriteScoreInFile();
                      PrintGameOver();
                      
                      hit = true;
                      break;
                  }
              }
              if (hit)
                  break;
         
              Thread.Sleep(100);
              Console.Clear();
              
             
          }

            while(true)
            {


                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).KeyChar;
                    if(key=='y')
                    {
                        Main();
                        break;
                    }
                    else
                    if (key=='n')
                        break;
                    Thread.Sleep(1000);
                }
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
                    points = Score(downObstacles);
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
            birdStartY = b.position.Y;
            for (int i = 0; i < b.bird.Length; i++)
            {

                PrintOnScreen(b.position.X, b.position.Y, b.bird[i], ConsoleColor.Yellow);
                b.position.Y++;
            }
            b.position.Y = birdStartY;
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
            ReDrawScore(points);
        }
        static void ReDrawScore(int score)
        {
            Point scorePosition = new Point(Console.BufferWidth - 20, 10);
            PrintOnScreen(scorePosition.X, scorePosition.Y,"SCORE: "+ score.ToString(), ConsoleColor.Yellow);
            PrintOnScreen(scorePosition.X, scorePosition.Y-2, "HIGH SCORE: " + HighScore(), ConsoleColor.Yellow);
            
        }
        static void AddObstacles(List<Obstacle> downObstacles,List<Obstacle>upObstacles,int i,int j)
        {
            downObstacles.Add(new Obstacle(j + 1, (i * 40) + i, Console.WindowHeight - (j + 1)));
            upObstacles.Add(new Obstacle(j + 1, (i * 40) + i, 0));
        }
        static int Score(List<Obstacle> obstacles)
        {
            int result = (50 - obstacles.Count)*2;
            return result;
        }
        static string HighScore()
        {
            try
            {

                StreamReader scoreRead = new StreamReader(@"..\Score.txt");
                string highScore = scoreRead.ReadLine();
                scoreRead.Close();
                return highScore;
            }
            catch (FileNotFoundException e)
            {
                StreamWriter writer=new StreamWriter(@"..\Score.txt");
                writer.WriteLine("0");
                writer.Close();
                return "0";
            }

            
            
        }
        static public void PlaySound(string s)
        {
            var startScreen = new System.Media.SoundPlayer(s);
            startScreen.Play();

           // @"Scary_Demon_Haunting.wav"
        }
        static void WriteScoreInFile()
        {

            StreamReader scoreRead = new StreamReader(@"..\Score.txt");

            string highScore = scoreRead.ReadLine();

            scoreRead.Close();
            if (highScore != null)
            {
                if (int.Parse(highScore) < points)
                {
                    var fs = new FileStream(@"..\Score.txt", FileMode.Truncate); // delete all text in the file
                    fs.Close();
                    StreamWriter file = new StreamWriter(@"..\Score.txt");
                    file.WriteLine(points.ToString());
                    file.Close();
                   }
            }
            else
            {
                StreamWriter file = new StreamWriter(@"..\Score.txt");
                file.WriteLine(points.ToString());
                file.Close();
                
            }


        }
        static void PrintGameOver()
        {
            PrintOnScreen(Console.BufferWidth - 35, 15, "Game over, you've got " + points + " points", ConsoleColor.Yellow);
            PrintOnScreen(Console.BufferWidth - 35, 16, "Restart the game Y/N", ConsoleColor.Yellow);
        }

    }
}
