using System;

class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        uint n;
        ulong  sumLines = 0;
        string[] matrix = new string[8];
        string word = "", hintString = "";
      
        int row = 0, column = 0;
        int numberOnes = 0;
        int numberZerosColumn = 0, numberColumnsForResult = 0;
        ulong number = 0;
        for (int i = 0; i < 8; i++)
        {
            n = uint.Parse(Console.ReadLine());
            matrix[i] = Convert.ToString(n, 2).PadLeft(width, '0');


        }
        while (true)
        {
            word = Console.ReadLine();
            if (word == "stop")
            {
                for (int j = 0; j < width; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        if (matrix[i][j] == '1')
                        {
                            numberZerosColumn++;
                        }
                    }
                    if (numberZerosColumn == 0)
                    {
                        numberColumnsForResult++;
                    }

                    numberZerosColumn = 0;
                }
                for (int i = 0; i < 8; i++)
                {

                    number = Convert.ToUInt32(matrix[i], 2);
                    sumLines += number;

                }
                Console.WriteLine(sumLines *(ulong)numberColumnsForResult);
                break;
            }
            else
                if (word == "reset")
                {
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (matrix[i][j] == '1')
                            {
                                numberOnes++;
                            }
                        }
                        hintString = new String('0', width - numberOnes);
                        hintString = new String('1', numberOnes) + hintString;
                        matrix[i] = hintString;
                        numberOnes = 0;

                    }
                }
                else
                {

                    row = int.Parse(Console.ReadLine());
                    column = int.Parse(Console.ReadLine());
                    if (column < 0)
                    {
                        column = 0;
                    }
                    else
                        if ( column>width-1)
                        {
                            column = width - 1;
                        }

                    if (word == "right")
                    {

                        for (int i = column; i < width; i++)
                        {
                            if (matrix[row][i] == '1')
                            {
                                numberOnes++;
                            }

                        }

                        hintString = matrix[row].Substring(0, column);
                        hintString += new String('1', numberOnes).PadLeft(width - column, '0');
                        matrix[row] = hintString;
                        numberOnes = 0;



                    }
                    else
                        if (word == "left")
                        {
                            for (int i = column; i >= 0; i--)
                            {
                                if (matrix[row][i] == '1')
                                {
                                    numberOnes++;
                                }
                            }
                            hintString = matrix[row].Substring(column + 1, width - column - 1);
                            hintString = new String('1', numberOnes).PadRight(column + 1, '0') + hintString;
                            matrix[row] = hintString;
                            numberOnes = 0;

                        }

                }

        }

    }

}

