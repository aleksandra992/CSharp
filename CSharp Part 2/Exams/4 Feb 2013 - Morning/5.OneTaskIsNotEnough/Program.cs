using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.OneTaskIsNotEnough
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLamps = int.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(FirstTask(numberOfLamps));
            
            Console.WriteLine(SecondTask(input1));
            Console.WriteLine(SecondTask(input2));
        }


        private static string SecondTask(string commands)
        {
            int[] movesX = { 1, 0, -1, 0 };
            int[] movesY = { 0, 1, 0, -1 };

            // Starting from (0,0)
            int currentX = 0, currentY = 0, direction = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < commands.Length; j++)
                {
                    switch (commands[j])
                    {
                        case 'S':
                            currentX += movesX[direction];
                            currentY += movesY[direction];
                            break;
                        case 'L':
                            direction = (direction + 3) % 4; // +270 degrees, turns left
                            break;
                        case 'R':
                            direction = (direction + 1) % 4; // +90 degrees, turns right
                            break;
                    }
                }
            }

            if (currentX == 0 && currentY == 0)
            {
                // After 4 commands execution he is back on the starting place
                return "bounded";
            }
            else
            {
                // He moved after 4 commands execution
                // He will move again and again in the same direction after every next commands execution
                return "unbounded";
            }
        }
        
        private static int FirstTask(int numberOfLamps)
        {
            int[] turnedOn = new int[numberOfLamps];
            int[] off=new int[numberOfLamps];
            for (int i = 0; i < turnedOn.Length; i++)
            {
                turnedOn[i] = i;
            }
            Array.Copy(turnedOn,off,turnedOn.Length);
            int br = 2;
            int k = 0;
            int turnedOnLenght = turnedOn.Length;
            while (turnedOnLenght > 1)
            {
                for (int j = 0; j < turnedOnLenght; j += br)
                {
                    turnedOn[j] = -1;
                }
                if (turnedOnLenght != 1)
                {
                    
                    for (int i = 0; i < turnedOnLenght; i++)
                    {

                        if (turnedOn[i] != -1)
                        {

                            off[k] = i;
                            k++;
                        }
                        else
                            turnedOn = off;
                    }
                        turnedOnLenght =k;
                    
                   }
                br++;
            }
            return turnedOn[0] + 1;
        }
        
    }
}

