

namespace Matrix_
{
    using System;
    using System.Collections;
    using System.Text;
   
    public class Matrix<T> where T : IComparable
    {
        private T[,] matrix;


        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
            this.Rows = rows;
            this.Columns = cols;

        }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public T this[int row, int column]
        {
            get
            {
                if (row > this.Rows - 1 || column > this.Columns - 1 || row < 0 || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Indexes {0}{1} is invalid", row, column));
                }
                return matrix[row, column];

            }
            set
            {
                if (row > this.Rows - 1 || column > this.Columns - 1 || row < 0 || column < 0)
                {
                    throw new IndexOutOfRangeException(String.Format("Indexes {0}{1} is invalid", row, column));

                }
                this.matrix[row, column] = value;
            }
        }
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
           
          
            if (!CheckType<T>.CheckTypeOf())
                throw new Exception("The operation + is not allowed");
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {

                throw new ArgumentOutOfRangeException("The both of the matrices have to have same dimensions");
            }
            Matrix<T> result=new Matrix<T>(m1.Rows,m2.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    
                    result[i, j] =(dynamic)m1[i, j]+m2[i, j];
                }
            }
            return result;
                
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (!CheckType<T>.CheckTypeOf())
                throw new Exception("The operation - is not allowed");
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
            {

                throw new ArgumentOutOfRangeException("The both of the matrices have to have same dimensions");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = (dynamic)m1[i, j] - m2[i, j];
                }
            }
            return result;

        }
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            T temp = (dynamic)0;
            if (!CheckType<T>.CheckTypeOf())
                throw new Exception("The operation - is not allowed");
            if (m1.Columns != m2.Rows)
            {
                
                throw new ArgumentOutOfRangeException("The dimensions are not allowed for this operation");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Columns);
          
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int k = 0; k < m2.Columns; k++)
                {
                    for (int j = 0; j < m1.Columns; j++)
                    {
                        temp += (dynamic)m1[i, j] * m2[j, i];
                    }
                    result[i, k] = temp;
                    temp = (dynamic)0;
                }

            }
            return result;

        }
        public static bool operator true(Matrix<T> m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    if (m[i, j] == (dynamic)0)
                        return false;
                }
            }
            return true;
        }
        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    if (m[i, j] == (dynamic)0)
                        return true ;
                }
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder k = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    k.Append(this.matrix[i, j]);
                    k.Append(" ");
                }
                k.Append("\n");
            }
            return k.ToString();
        }
      
    }
}
