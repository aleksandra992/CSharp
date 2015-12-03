namespace Portals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Position
    {
        public int row;

        public int col;

        public string Portals;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    class Program
    {

        public static Position myPosition;

        public static Position[,] matrix;

        public static string[,] visited;

        public static string[,] original;

        private static readonly sbyte[] DeltaRow = { 1, -1, 0, 0 };//down,up,right,left

        private static readonly sbyte[] DeltaCol = { 0, 0, 1, -1 };
        static void Main(string[] args)
        {
            var inputPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var inputMatrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new Position[inputMatrixDimensions[0], inputMatrixDimensions[1]];
            visited = new string[inputMatrixDimensions[0], inputMatrixDimensions[1]];
            original = new string[inputMatrixDimensions[0], inputMatrixDimensions[1]];
            for (var i = 0; i < inputMatrixDimensions[0]; i++)
            {
                string[] line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (var j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = new Position(i, j);
                    matrix[i, j].Portals = line[j].ToString();
                    visited[i, j] = line[j].ToString();
                    original[i, j] = line[j].ToString();
                }
            }
            myPosition = matrix[inputPosition[0], inputPosition[1]];

            TraverseLabyrinth();
            int resMax = int.MinValue;
            int currRes = 0;
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].Portals != "#")
                    {
                        currRes = int.Parse(matrix[i, j].Portals);
                        if (currRes > resMax)
                        {
                            resMax = currRes;
                        }
                    }
                }
            }
            Console.WriteLine(resMax);

        }

        public static void TraverseLabyrinth()
        {
            var nodes = new Queue<Position>();
            nodes.Enqueue(myPosition);
            visited[myPosition.row, myPosition.col] = "0";
            while (nodes.Count != 0)
            {
                var currentNode = nodes.Dequeue();
                var pom = original[currentNode.row, currentNode.col];
                Console.WriteLine(currentNode);

                for (int i = 0; i < DeltaCol.Length; i++)
                {
                    var position = new Position(currentNode.row + DeltaRow[i] * int.Parse(pom), currentNode.col + DeltaCol[i] * int.Parse(pom));
                    if (isValidPosition(position) && isCellPortal(matrix[position.row, position.col]))
                    {

                        var neighbor = matrix[position.row, position.col];
                        var visitiedPortal = visited[position.row, position.col];
                        if (visitiedPortal != "0" && visitiedPortal != "#")
                        {
                            neighbor.Portals = (int.Parse(neighbor.Portals) + int.Parse(currentNode.Portals)).ToString();
                            nodes.Enqueue(neighbor);
                            visited[neighbor.row, neighbor.col] = "0";
                        }
                    }
                }
            }
        }

        public static bool isCellPortal(Position position)
        {
            if (position.Portals == "#")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isValidPosition(Position position)
        {
            if (position.row >= 0 && position.row < matrix.GetLength(0) && position.col >= 0
                && position.col < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
