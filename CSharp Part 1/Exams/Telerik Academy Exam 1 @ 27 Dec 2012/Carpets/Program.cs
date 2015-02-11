using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int countLeftDots = (width - 2) / 2, countLeftSlashes = 1, countEmptySpaces = 0, countEmptySpace2 = 2;
        string leftDots = new String('.', countLeftDots);

        string leftSlash1 = new String('/', countLeftSlashes);
        string rightSlash1 = new String('\\', countLeftSlashes);
        string emptySpace = new String(' ', countEmptySpaces);
        string  s1 = "",s2 ="",s3="",s4="";
        int n = 1;
        for (int i = 0; i < width / 4; i++)
        {
            
            
                //Console.WriteLine(leftDots +s3+s4 + leftDots);
                //countLeftDots--;
                for (int j = 0; j < n; j++)
                {
                    s1 += "/ ";
                    s2 += " \\";
                }
                s3 = s1.TrimEnd(' ');
                s4 = s2.TrimStart(' ');
                n++;
                leftDots = new String('.', countLeftDots);
            
                Console.WriteLine(leftDots + s3 + s4 + leftDots);
                countLeftDots--;
                leftDots = new String('.', countLeftDots);
                Console.WriteLine(leftDots + s1 + s2 + leftDots);

                countLeftDots--;
                s1 = "";
                s2 = "";

            
        }
        if ((width / 2) % 2 != 0)
        {
            leftDots = new String('.', countLeftDots);
            Console.WriteLine(leftDots + s3 + " /" + "\\ " + s4 + leftDots);

            Console.WriteLine(leftDots + s4 + " \\" + "/ " + s3 + leftDots);
            countLeftDots = 1;
        }
        else
        {
            countLeftDots = 0;
        }
        n--;
       
        for (int i = 0; i < width / 4; i++)
        {
            
            for (int j = 0; j < n; j++)
            {
                s1 += "\\ ";
                s2 += " /";
            }
            s3 = s1.TrimEnd(' ');
            s4 = s2.TrimStart(' ');
            n--;
            leftDots = new String('.', countLeftDots);
            Console.WriteLine(leftDots + s1 + s2 + leftDots);
            countLeftDots++;
            leftDots = new String('.', countLeftDots);
            Console.WriteLine(leftDots + s3 + s4 + leftDots);

            countLeftDots++;
            s1 = "";
            s2 = "";
        }
    }
}

