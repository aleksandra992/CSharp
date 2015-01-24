using System;


namespace _2.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a score between [1-9]");
            int score = int.Parse(Console.ReadLine());
            int flag = 0;
            if (score >= 1 && score <= 3)
            {
                score *= 10;
                flag = 1;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                flag = 1;
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                flag = 1;
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            if (flag == 1)
            {
                Console.WriteLine(score);
            }

            
        }
    }
}
