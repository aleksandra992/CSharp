namespace Minesweeper
{
    public class Score
    {
        private string playerName;
        private int playerScore;

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int PlayerScore
        {
            get { return playerScore; }
            set { playerScore = value; }
        }

        public Score() { }

        public Score(string playerName, int playerScore)
        {
            this.PlayerName = playerName;
            this.PlayerScore = playerScore;
        }
    }
}