﻿namespace Stools
{
    using System;

    class Program
    {
        static Stool[] stools;
        private static int n;
        private static int[,,] memo;

        static int MaxHeight(int used, int top, int side)
        {
            if (memo[used, top, side] != 0)
            {
                return memo[used, top, side];
            }

            if (used == (1 << top))
            {
                if (side == 0)
                {
                    return stools[top].X;
                }
                if (side == 1)
                {
                    return stools[top].Y;
                }

                return stools[top].Z;
            }

            int fromStools = used ^ (1 << top);

            int sideX = (side == 0) ? stools[top].Y : stools[top].X;
            int sideY = (side == 2) ? stools[top].Y : stools[top].Z;
            int sideH = stools[top].X + stools[top].Y + stools[top].Z - sideX - sideY;

            int result = sideH;

            for (int i = 0; i < n; i++)
            {
                if (((fromStools >> i) & 1) == 1)
                {

                    // side of stools[i] == 0;
                    if (stools[i].Y >= sideX && stools[i].Z >= sideY
                        || stools[i].Y >= sideY && stools[i].Z >= sideX)
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 0) + sideH);
                    }

                    if (stools[i].X == stools[i].Y && stools[i].X == stools[i].Z)
                    {
                        continue;
                    }

                    // side of stools[i] == 1;
                    if (stools[i].X >= sideX && stools[i].Z >= sideY
                        || stools[i].X >= sideY && stools[i].Z >= sideX)
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 1) + sideH);
                    }

                    // side of stools[i] == 2;
                    if (stools[i].X >= sideX && stools[i].Y >= sideY
                        || stools[i].X >= sideY && stools[i].Y >= sideX)
                    {
                        result = Math.Max(result, MaxHeight(fromStools, i, 2) + sideH);
                    }
                }

            }

            memo[used, top, side] = result;
            return result;
        }

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            stools = new Stool[n];
            memo = new int[1 << n, n, 3];
            //memo = new int[1 << n, 16, 4];

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                stools[i] = new Stool(int.Parse(line[0]), int.Parse(line[1]), int.Parse(line[2]));
            }

            for (int i = 0; i < n; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    result = Math.Max(result, MaxHeight((1 << n) - 1, i, j));
                }
            }
            Console.WriteLine(result);
        }
    }
}