namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Table : Element, ITable
    {
        private int rows;
        private int cols;
        private IElement[,] table;
        private const string name = "table";
        public Table(int rows, int cols)
            : base(name, null)
        {
            this.Rows = rows;
            this.Cols = cols;
            table = new Element[this.Rows, this.Cols];
        }
        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The rows cannot be less or equal to zero");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Thecolumns cannot be less or equal to zero");
                }
                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("The row and col cannot be less than zero");
                }

                return this.table[row, col];
            }
            set
            {
                if (row < 0 || col < 0)
                {
                    throw new ArgumentOutOfRangeException("The row and col cannot be less than zero");
                }
                this.table[row, col] = value;
            }
        }
        public override void Render(StringBuilder output)
        {
            output.Append("<table>");
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(string.Format("<td>{0}</td>", this.table[row, col].ToString()));
                }
                output.Append("</tr>");
            }
            output.Append("</table");

        }

        public override string ToString()
        {
            StringBuilder tableString = new StringBuilder();
            this.Render(tableString);
            return tableString.ToString();
        }
    }
}
