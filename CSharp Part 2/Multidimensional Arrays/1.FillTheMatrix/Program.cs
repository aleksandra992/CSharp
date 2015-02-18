using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int[,] matrix3 = new int[n, n];
        int[,] matrix4 = new int[n, n];
        int br = 0;
        //first matrix
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                br++;
                matrix1[row, col] = br;
            }
        }
        br = 1;
        //second matrix
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix2[row, col] = br;
                    br++;
                }
            }
            else
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix2[row, col] = br;
                    br++;
                }
        }
        //third matrix
        br = 1;
        int brRow = n;
        
        int column = 0;

        int flag = 0;//flag is 0 on left-down,flag is 1 on top-right
        int pomN = n;
        
        int brCol = 0;
        for (int i = 0; i < 2 * n-1; i++)
        {
            if (flag == 0)
            {
                brRow--;
            }
            if (flag == 1)
            {
                
                pomN--;
            }
            brCol = pomN;
            for (int row = brRow; row < pomN; row++)
            {
                
                if (flag == 0)
                {
                    column = row - brRow;
                }
                else
                {
                    column = n- brCol;
                    brCol--;
                   
                }
                
                matrix3[row, column] = br;
                br++;

            }
       

            
            if (brRow == 0)
            {
                flag = 1;
                
            }




        }
        int X = 0, Y = 0;
        br = 0;
        int count = n * n;
        //fourth matrix
        while (br < count)
        {
            if (n == 1)
            {
                br++;

                matrix4[X, Y] = br;
                break;
            }
            for (int i = 0; i < n - 1; i++)
            {

                br++;
                matrix4[X, Y] = br;
                X++;
            }
            for (int j = 0; j < n - 1; j++)
            {
                br++;
                matrix4[X, Y] = br;
                Y++;
            }
            for (int k = 0; k < n - 1; k++)
            {
                br++;
                matrix4[X, Y] = br;
                X--;
            }
            for (int i = 0; i < n - 1; i++)
            {
                br++;
                matrix4[X, Y] = br;
                Y--;
            }

            n -= 2;
            X++;
            Y++;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                Console.Write(matrix3[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < matrix4.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4.GetLength(1); j++)
            {
                Console.Write(matrix4[i, j] + " ");
            }
            Console.WriteLine();
        }
      //  Console.ReadKey();
    }

}

