
using System;

namespace Singleton
{
    public class StartPoint
    {
        static void Main(string[] args)
        {
            var firstHighScore = HighScore.Instance;
            firstHighScore.SaveHighScore("Aleksandra", 95);
            var secondHighScore = HighScore.Instance;
            Console.WriteLine(firstHighScore);
            Console.WriteLine(secondHighScore);
            secondHighScore.SaveHighScore("Goran", 96);
            Console.WriteLine(firstHighScore);
            Console.WriteLine(secondHighScore);
        }
    }
}
