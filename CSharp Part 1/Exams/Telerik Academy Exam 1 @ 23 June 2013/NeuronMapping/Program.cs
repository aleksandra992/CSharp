using System;
using System.IO;

class Program
{
    static void Main()
    {
        //StreamReader reader=new StreamReader("..\\..\\sample-text.txt");
        //Console.SetIn(reader);
        string[] matrix = new string[32];
        int sizeMatrix = 0;
        uint number;
        for (int i = 0; i < 32; i++)
        {
            if (uint.TryParse(Console.ReadLine(), out number))
            {
                sizeMatrix++;
                matrix[i] = Convert.ToString(number, 2).PadLeft(32, '0');
            }
            else
            {
                break;
            }


        }
        int flag1 = 0, flag2 = 0;
        string pomString = "";
        int j = 0;
        for (int row = 0; row < sizeMatrix; row++)
        {
            for (int column = 0; column < 32; column++)
            {
                if (column < 32 && flag1 == 0 && matrix[row][column] == '0' && flag2 == 0)
                {
                    pomString += matrix[row][column];
                }

                if (column < 32 && matrix[row][column] == '1')
                {

                    while (column < 32 && matrix[row][column] == '1')
                    {
                        column++;
                        pomString += '0';
                    }
                    // column--;
                    j = column;

                    while (j < 32)
                    {
                        if (matrix[row][j] == '1')
                        {
                            flag2 = 1;
                        }
                        j++;
                    }
                    flag1 = 1;

                }

                if (column < 32 && flag1 == 1 && matrix[row][column] == '0' && flag2 == 1)
                {

                    while (column < 32 && matrix[row][column] == '0')
                    {
                        column++;
                        pomString += '1';
                    }
                    column--;
                    flag2 = 0;
                    flag1 = 0;
                }

                if (column < 32 && flag1 == 1 && matrix[row][column] == '0' && flag2 == 0)
                {
                    pomString += matrix[row][column];
                }


            }
            matrix[row] = pomString;
            pomString = "";
            flag1 = 0;
            flag2 = 0;
        }
        //  uint n=0;
        for (int i = 0; i < sizeMatrix; i++)
        {

            Console.WriteLine(Convert.ToUInt32(matrix[i], 2));
        }
    }
}