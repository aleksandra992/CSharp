using System;
using System.Collections.Generic;

namespace Labyrinth
{
    public class Startup
    {

        private static readonly int[] deltaX = { -1, 0, 1, 0 };//left,down,right,up
        private static readonly int[] deltaY = { 0, 1, 0, -1 };
        private const string FullCell = "x";
        private const string EmptyCell = "0";
        private const string UnreachableCell = "u";
        private const string StartCell = "*";

        public static void Main()
        {
            string[,] labyrinth =
                                 {
                {"0", "0", "0", "x", "0", "x"},
                {"0", "x", "0", "x", "0", "x"},
                {"0", "*", "x", "0", "x", "0"},
                {"0", "x", "0", "0", "0", "0"},
                {"0", "0", "0", "x", "x", "0"},
                {"0", "0", "0", "x", "0", "x"}
            };


            var startingPosition = new Position();

            for (var i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (var j = 0; j < labyrinth.GetLength(1); j++)
                {
                    var element = labyrinth[i, j];
                    if (element == StartCell)
                    {
                        startingPosition.Row = i;
                        startingPosition.Col = j;
                    }
                }
            }

            PrintMatrix(TraverseMatrix(startingPosition, labyrinth), labyrinth);
        }

        public static string[,] TraverseMatrix(Position startingPosition, string[,] labyrinth)
        {
            int[,] visited = new int[labyrinth.GetLength(0), labyrinth.GetLength(1)];
            string[,] resultMatrix = new string[labyrinth.GetLength(0), labyrinth.GetLength(1)];
            Queue<QueueItem> queue = new Queue<QueueItem>();
            queue.Enqueue(new QueueItem() { Value = 0, Position = startingPosition });
            resultMatrix[startingPosition.Row, startingPosition.Col] = "*";
            visited[startingPosition.Row, startingPosition.Col] = 1;
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                for (var i = 0; i < deltaX.Length; i++)
                {
                    var newPosition = new Position(current.Position.Row + deltaX[i], current.Position.Col + deltaY[i]);

                    if (newPosition.Row >= labyrinth.GetLength(0) || newPosition.Col >= labyrinth.GetLength(1)
                        || newPosition.Row < 0 || newPosition.Col < 0)
                    {
                        continue;
                    }

                    if (labyrinth[newPosition.Row, newPosition.Col] == "x")
                    {
                        continue;
                    }


                    if (visited[newPosition.Row, newPosition.Col] == 0)
                    {
                        queue.Enqueue(new QueueItem() { Value = current.Value + 1, Position = newPosition });
                        resultMatrix[newPosition.Row, newPosition.Col] = (current.Value + 1).ToString();
                    }
                    visited[newPosition.Row, newPosition.Col] = 1;
                }

            }
            return resultMatrix;
        }

        public static void PrintMatrix(string[,] matrix, string[,] labyrinth)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "x")
                    {
                        matrix[i, j] = "x";
                    }
                }
            }

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == null)
                    {
                        Console.Write("u   ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}