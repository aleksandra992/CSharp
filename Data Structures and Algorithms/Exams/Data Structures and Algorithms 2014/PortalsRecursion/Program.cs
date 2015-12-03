using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalsRecursion
{



    class Program
    {
        public static int[,] matrix;

        public static int max;

        public static bool[,] visited;
        static void Main(string[] args)
        {
            var inputPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var inputMatrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            matrix = new int[inputMatrixDimensions[0], inputMatrixDimensions[1]];
            visited = new bool[inputMatrixDimensions[0], inputMatrixDimensions[1]];
            for (var i = 0; i < inputMatrixDimensions[0]; i++)
            {
                string[] line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (var j = 0; j < line.Length; j++)
                {
                    if (!int.TryParse(line[j], out matrix[i, j]))
                    {
                        matrix[i, j] = -1;
                    }
                }
            }

            Traverse(0, inputPosition[0], inputPosition[1]);
            Console.WriteLine(max);
        }

        public static void Traverse(int portals, int row, int col)
        {

            if (row >= matrix.GetLength(0) || row < 0 || col >= matrix.GetLength(1) || col < 0)
            {
                return;
            }
            if (visited[row, col]) return;

            var current = matrix[row, col];

            if (current == -1) return;
            if (row + current >= matrix.GetLength(0) && row - current < 0 && col + current >= matrix.GetLength(1)
                && col - current < 0)
            {
                return;
            }
            portals += current;

            max = Math.Max(portals, max);
            visited[row, col] = true;

            Traverse(portals, row, col + current);
            Traverse(portals, row + current, col);
            Traverse(portals, row, col - current);
            Traverse(portals, row - current, col);
            visited[row, col] = false;

        }
    }
}
