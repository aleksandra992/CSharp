using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows");
            int rows= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns ");
            int columns = int.Parse(Console.ReadLine());
            if (rows < 3 || columns < 3)
            {
                Console.WriteLine("Number of rows and column must be equal or greater that 3");
                return;
            }
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("Enter [{0}{1}]=", col, row);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            if (rows == 3 && columns == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(matrix[i, j] + "");
                    }
                    Console.WriteLine();
                }
                return;
            }
           
           
            int[,] pomMatrix=new int[3,3];
            int maxSum = Int16.MinValue;
            int tempSum = 0;
            for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
            {
                for(int col = 0; col<=matrix.GetLength(1)-3;col++)
                {
                    tempSum=matrix[row,col]+matrix[row,col+1]+matrix[row,col+2]
                        +matrix[row+1,col]+matrix[row+1,col+1]+matrix[row+1,col+2]
                        +matrix[row+2,col]+matrix[row+2,col+1]+matrix[row+2,col+2];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;


                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                pomMatrix[i, j] = matrix[row + i, col + j];
                            }
                        }
                       
                    }
                }
              
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(pomMatrix[i, j] + "");       
                }
                Console.WriteLine();
            }
               // Console.ReadKey();
            
        }
    }
}
