namespace Labyrinth
{
    public class Position
    {
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public Position()
        {
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
