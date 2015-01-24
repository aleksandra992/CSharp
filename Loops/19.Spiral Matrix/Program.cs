using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = n;
        int count = n * n;
        int[,] matrix = new int[n, n];
        int br = 0;
        int x = 0, y = 0;
        while (br < count)
        {
            if (n == 1)
            {
                br++;

                matrix[x, y] = br;
                break;
            }
            for (int i = 0; i < n - 1; i++)
            {

                br++;
                matrix[y, x] = br;
                x++;
            }
            for (int j = 0; j < n - 1; j++)
            {
                br++;
                matrix[y, x] = br;
                y++;
            }
            for (int k = 0; k < n - 1; k++)
            {
                br++;
                matrix[y, x] = br;
                x--;
            }
            for (int i = 0; i < n - 1; i++)
            {
                br++;
                matrix[y, x] = br;
                y--;
            }

                n -= 2;
            x++;
            y++;
        }

        for (int l = 0; l < m; l++) //Print the  matrix in the console
        {
            for (int k = 0; k < m; k++)
                Console.Write(matrix[l, k]);
            Console.Write("\n");
        }

    }
}

