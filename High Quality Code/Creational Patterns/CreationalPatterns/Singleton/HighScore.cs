using System;
namespace Singleton
{
    public class HighScore
    {
        private static HighScore highScoreInstance;
        private int score;
        private string name;

        private HighScore()
        {
        }

        public static HighScore Instance
        {
            get
            {
                if (highScoreInstance == null)
                {
                    highScoreInstance = new HighScore();
                }
                return highScoreInstance;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }

        public void SaveHighScore(string name, int score)
        {
            this.score = score;
            this.name = name;

        }

        public override string ToString()
        {
            return String.Format("The high score is {0} and it from {1}", this.name, this.score);
        }
    }
}
