

namespace Matrix_
{
    using System;

   public class MatrixTesting
    {
       public static void Main()
        {
          
           





            Matrix<int> matrix = new Matrix<int>(5, 10);
            Matrix<int> operandOne = new Matrix<int>(3, 7);
            Matrix<int> operandTwo = new Matrix<int>(3, 7);
            Matrix<int> operandThree = new Matrix<int>(7, 3);

           for(int i=0;i<5;i++)
               for(int j=0;j<10;j++)
               {
                   matrix[i, j] = j;
               }

           for (int i = 0; i < 3; i++)
               for (int j = 0; j < 7; j++)
               {
                   operandOne[i, j] = j;
                   operandTwo[i, j] = i;
               }

           for (int i = 0; i < 7; i++)
               for (int j = 0; j < 3; j++)
               {
                   operandThree[i, j] = j;
               }

           Console.WriteLine("Operand one matrix = \n {0}", operandOne.ToString());
           Console.WriteLine("Operand two matrix = \n {0}", operandTwo.ToString());
           Console.WriteLine("Operand three matrix= \n {0}", operandThree.ToString());

           Console.WriteLine("OperandOne+OperandTwo = \n {0}",operandOne + operandTwo);
           Console.WriteLine("Operand-OperandTwo = \n {0}", operandOne - operandTwo);
           Console.WriteLine("OperandOne*OperandThree = \n {0}", operandOne * operandThree);
            if (operandOne)
            {
                Console.WriteLine("The operand one doesn't contains 0");
            }
            else
                Console.WriteLine("The operand one contains 0");
           
        }
        }
    }

