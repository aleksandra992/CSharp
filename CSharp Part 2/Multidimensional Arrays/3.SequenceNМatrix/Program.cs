using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SequenceNМatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns ");
            int columns = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("Enter [{0}{1}]=", col, row);
                    matrix[row, col] = Console.ReadLine();
                }
            }
            List<string> temp = new List<string>();
            List<string> max = new List<string>();
            int tempLenght = 0;
            int maxLenght = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    tempLenght = (int)Math.Max((decimal)Horizontal(row, col, matrix).Count, Math.Max((decimal)Vertical(row, col, matrix).Count, (decimal)Diagonal(row, col, matrix).Count));
                    if (tempLenght == Horizontal(row, col, matrix).Count)
                    {
                        temp = Horizontal(row, col, matrix);
                    }
                    if (tempLenght == Vertical(row, col, matrix).Count)
                    {
                        temp = Vertical(row, col, matrix);
                    }
                    if (tempLenght == Diagonal(row, col, matrix).Count)
                    {
                        temp = Diagonal(row, col, matrix);
                    }
                    if (tempLenght > maxLenght)
                    {
                        maxLenght = tempLenght;
                        max = new List<string>(temp);
                    }
                }
            }

            Console.WriteLine(string.Join(",", max));
           
        }

        static List<string> Horizontal(int row, int col, string[,] matrix)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);
            int j = 1;
            for (int i = col; i < matrix.GetLength(1)-1; i++)
            {
                if (matrix[row, col] == matrix[row, col + j])
                {
                    sequence.Add(matrix[row, col + j]);
                    j++;
                }
                else
                    break;
            }


            return sequence;
        }
        static List<string> Vertical(int row, int col, string[,] matrix)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);
            int j = 1;
            for (int i = row; i < matrix.GetLength(0)-1; i++)
            {
                if (matrix[row, col] == matrix[row+j, col])
                {
                    sequence.Add(matrix[row+j, col]);
                }
                else
                    break;
            }


            return sequence;
        }

        static List<string> Diagonal(int row, int col, string[,] matrix)
        {
            List<string> sequence = new List<string>();
            sequence.Add(matrix[row, col]);
            int j = 1;
            int granica = 0;
            if (matrix.GetLength(0) < matrix.GetLength(1))
            {
                granica = matrix.GetLength(0);
            }
            else
                granica = matrix.GetLength(1);
            for (int i = row; i <granica - 1; i++)
            {
                if (matrix[row, row] == matrix[row + j, row+j])
                {
                    sequence.Add(matrix[row + j, row+j]);
                }
                else
                    break;
            }


            return sequence;
        }
    }
}
