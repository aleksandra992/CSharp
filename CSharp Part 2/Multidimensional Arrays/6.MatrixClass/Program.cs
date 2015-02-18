using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            Matrix m1 = new Matrix();
            Matrix sumMatrix = new Matrix();
            Matrix difMatrix=new Matrix();
            Console.WriteLine("Enter the number of rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of cols");
            int cols = int.Parse(Console.ReadLine());
            m.matrix = new int[rows, cols];
            m1.matrix = new int[rows, cols];
            sumMatrix.matrix = new int[rows, cols];
            difMatrix.matrix=new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("enter [{0}-{1}] of the first matrix",i,j);
                    m.Add(int.Parse(Console.ReadLine()),i, j);
                    Console.WriteLine("enter [{0}-{1}] of the second matrix", i, j);
                    m1.Add(int.Parse(Console.ReadLine()),i,j);
                }
            }
            if (m1.matrix.GetLength(0) == m.matrix.GetLength(0) && m1.matrix.GetLength(1) == m.matrix.GetLength(1))
            {
                sumMatrix = m1 + m;
                difMatrix = m1 - m;
            }
            else
                Console.WriteLine("The size of the two matrix are different so the operator for - and + are impossible");

            Console.WriteLine(m.ToString());
            Console.WriteLine(m1.ToString());
            Console.WriteLine("The sum is {0}", sumMatrix.ToString());
            Console.WriteLine("The difference is{0}", difMatrix.ToString());
          

        }
    }
   
}
