namespace Loop
{
    using System;

    public class StartingPoint
    {
       public static void Main(string[] args)
        {
            ForLoop loop = new ForLoop();
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           loop.FoundValueInPositionDivisibleByTen(numbers, 10);
           loop.PrintValues(numbers);
        }
    }
}
