namespace IfStatements
{
    using System;
    using System.Drawing;

    public class VisitCellIfStatement
    {
        public const int MinX = 1;
        public const int MaxX = 100;
        public const int MinY = 5;
        public const int MaxY = 50;
        private bool shouldVisitCell = true;

        public void Move(Point point)
        {
            if (this.CheckIfPointIsInside(point))
            {
                this.VisitCell();
            }
        }

        public bool CheckIfPointIsInside(Point point)
        {
            bool insideY = (point.Y <= MaxY) && (point.Y >= MinY);
            bool insideX = (point.X <= MaxY) && (point.X >= MinY);
            if (insideX && insideY && shouldVisitCell)
            {
                return true;
            }

            return false;
        }

        public void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
