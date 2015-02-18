using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MatrixClass
{
    class Matrix
    {
         public int[,] matrix;

     public void Add(int element,int row,int col)
        {
         
            matrix[row, col] = element;
 
        }

      public static Matrix operator -(Matrix m, Matrix m1)
     {
         Matrix rez = new Matrix();
         rez.matrix = new int[m.matrix.GetLength(0), m.matrix.GetLength(1)];
         for (int i = 0; i < m.matrix.GetLength(0); i++)
         {
             for (int j = 0; j < m.matrix.GetLength(1); j++)
             {
                 rez.matrix[i, j] = m.matrix[i, j] - m1.matrix[i, j];
             }
         }
         return rez;

     }
    public static Matrix operator +(Matrix m,Matrix m1)
     {
         Matrix rez = new Matrix();
         rez.matrix = new int[m.matrix.GetLength(0), m.matrix.GetLength(1)];
         for (int i = 0; i <m.matrix.GetLength(0); i++)
         {
             for (int j = 0; j <m.matrix.GetLength(1); j++)
             {
                 rez.matrix[i, j] =m.matrix[i, j] + m1.matrix[i, j];
             }
         }
         return rez;
 
     }
     public override string ToString()
     {
         StringBuilder str = new StringBuilder();
         for (int i = 0; i < this.matrix.GetLength(0); i++)
         {
             for (int j = 0; j < this.matrix.GetLength(1); j++)
             {
                 str.Append(this.matrix[i, j] + " ");
             }
             str.AppendLine();
         }
         return str.ToString() ;
     }
     public int GetElementAt(int i, int j)
     {
         return this.matrix[i, j];
     }

    
    }
}
