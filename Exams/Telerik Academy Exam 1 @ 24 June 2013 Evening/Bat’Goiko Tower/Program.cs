using System;

    class Program
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int countLeftDots = height - 1, countCenterLinesAndDots = 0; ;
            string leftDots = "";
            string centerLines = "", centerDots = "";
            leftDots = new String('.', countLeftDots);
            int n=1;
            Console.WriteLine(leftDots + '/' + '\\' + leftDots);
          
            for (int i = 1; i < height; i++)
            {
                countLeftDots--;
                countCenterLinesAndDots += 2;
                leftDots = new String('.', countLeftDots);
              
                centerLines = new String('-', countCenterLinesAndDots);

                Console.WriteLine(leftDots + '/' + centerLines + '\\' + leftDots);
                
                    for (int k = 0; k < n && i<height-1; k++)
                    {
                        countLeftDots--;
                        countCenterLinesAndDots += 2;
                        leftDots = new String('.', countLeftDots);
                        centerDots = new String('.', countCenterLinesAndDots);
                        Console.WriteLine(leftDots + '/' + centerDots + '\\' + leftDots);
                        i++;
                    }
                    n++;
                

            }
        }
    }

