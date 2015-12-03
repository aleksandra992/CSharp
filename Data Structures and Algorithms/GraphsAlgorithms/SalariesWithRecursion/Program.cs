namespace SalariesWithRecursion
{
    using System;

    public class Program
    {
        public static char[][] matrix;

        public static long[] memo;
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new char[n][];
            memo = new long[n];

            for (var i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                matrix[i] = row;
            }
            long salary = 0;
            for (int i = 0; i < n; i++)
            {
                salary += Salary(i, n);
            }

            Console.WriteLine(salary);
        }

        public static long Salary(int row, int n)
        {
            if (memo[row] != 0)
            {
                return memo[row];
            }

            long salary = 0;
            bool flag = false;
            for (var j = 0; j < n; j++)
            {
                if (matrix[row][j] == 'Y')
                {
                    flag = true;
                    salary += Salary(j, n);
                }
            }

            if (flag == false)
            {
                memo[row] = 1;
                return 1;

            }

            memo[row] = salary;
            return salary;
        }


    }
}
