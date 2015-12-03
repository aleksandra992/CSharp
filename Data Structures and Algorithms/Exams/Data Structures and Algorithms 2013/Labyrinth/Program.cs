using System;
using System.Collections.Generic;
using System.Linq;

namespace Labyrinth
{

    public struct Position
    {
        public sbyte level;

        public sbyte row;

        public sbyte col;

        public int Distance;
        public Position(sbyte level, sbyte row, sbyte col) : this()
        {
            this.level = level;
            this.row = row;
            this.col = col;
        }
    }


    class Program
    {
        private static readonly sbyte[] DeltaLevel = { 0, 0, 0, 0 }; ////front,back,right,left
        private static readonly sbyte[] DeltaRow = { 1, -1, 0, 0 };

        private static readonly sbyte[] DeltaCol = { 0, 0, 1, -1 };

        private static bool[,,] visited;
        static char[,,] labirinth;

        static sbyte levels;
        static sbyte rows;
        static sbyte cols;
        static Position myPosition;
        static void Main(string[] args)
        {
            var myPositionInput = Console.ReadLine().Split(' ').Select(sbyte.Parse).ToArray();
            myPosition = new Position(myPositionInput[0], myPositionInput[1], myPositionInput[2]);
            myPosition.Distance = 0;
            var labyrinthDimInput = Console.ReadLine().Split(' ').Select(sbyte.Parse).ToArray();

            levels = labyrinthDimInput[0];
            rows = labyrinthDimInput[1];
            cols = labyrinthDimInput[2];

            labirinth = new char[levels, rows, cols];
            visited = new bool[levels, rows, cols];

            for (var level = 0; level < levels; level++)
            {
                for (var row = 0; row < rows; row++)
                {
                    var rowInput = Console.ReadLine().ToCharArray();
                    for (var col = 0; col < cols; col++)
                    {
                        labirinth[level, row, col] = rowInput[col];
                    }
                }
            }
            TraverseLabirinth();

        }

        private static bool IsRowAndColValid(Position position)
        {
            if (position.row < rows && position.row >= 0
                && position.col < cols && position.col >= 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsLevelValid(Position position)
        {
            if (position.level >= 0 && position.level < levels)
            {
                return true;
            }
            return false;
        }


        public static void TraverseLabirinth()
        {
            var positions = new Queue<Position>();
            positions.Enqueue(myPosition);
            visited[myPosition.level, myPosition.row, myPosition.col] = true;
            while (positions.Count != 0)
            {
                var currentPosition = positions.Dequeue();
                var currentNode = labirinth[currentPosition.level, currentPosition.row, currentPosition.col];

                if (currentNode == 'U')
                {

                    var upNeighbor = new Position(
                       (sbyte)(currentPosition.level + 1),
                        currentPosition.row,
                        currentPosition.col);
                    upNeighbor.Distance = currentPosition.Distance + 1;
                    
                    if (!IsLevelValid(upNeighbor) && IsRowAndColValid(upNeighbor))
                    {
                        Console.WriteLine(upNeighbor.Distance);
                        break;
                    }
                   
                    if (IsRowAndColValid(upNeighbor) && IsLevelValid(upNeighbor))
                    {
                        var upNeighborNode = labirinth[upNeighbor.level, upNeighbor.row, upNeighbor.col];
                        if (upNeighborNode == '#')
                        {
                            continue;

                        }
                        positions.Enqueue(upNeighbor);
                        visited[upNeighbor.level, upNeighbor.row, upNeighbor.col] = true;
                    }
                    continue;

                }
                else if (currentNode == 'D')
                {
                    var downNeighbor = new Position(
                        (sbyte)(currentPosition.level - 1),
                        currentPosition.row,
                        currentPosition.col);
                    downNeighbor.Distance = currentPosition.Distance + 1;
                  
                    if (!IsLevelValid(downNeighbor) && IsRowAndColValid(downNeighbor))
                    {
                        Console.WriteLine(downNeighbor.Distance);
                        break;
                    }
                   
                    if (IsRowAndColValid(downNeighbor) && IsLevelValid(downNeighbor))
                    {
                        var downNeighborNode = labirinth[downNeighbor.level, downNeighbor.row, downNeighbor.col];
                        if (downNeighborNode == '#')
                        {
                            continue;

                        }
                        positions.Enqueue(downNeighbor);
                        visited[downNeighbor.level, downNeighbor.row, downNeighbor.col] = true;
                    }
                    continue;

                }


                for (int i = 0; i < DeltaRow.Length; i++)
                {
                    var neighborPosition = new Position(
                        (sbyte)(currentPosition.level + DeltaLevel[i]),
                        (sbyte)(currentPosition.row + DeltaRow[i]),
                        (sbyte)(currentPosition.col + DeltaCol[i]));
                    neighborPosition.Distance = currentPosition.Distance + 1;

                    if (IsRowAndColValid(neighborPosition))
                    {
                        var neighbor = labirinth[neighborPosition.level, neighborPosition.row, neighborPosition.col];

                        if (neighbor != '#' && (visited[neighborPosition.level, neighborPosition.row, neighborPosition.col] == false))
                        {
                            positions.Enqueue(neighborPosition);
                            visited[neighborPosition.level, neighborPosition.row, neighborPosition.col] = true;
                        }
                    }
                }
            }
        }
    }
}