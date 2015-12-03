namespace RecoverMessage
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {

            //var matrix = new int[,]
            //                {
            //                     { 0, 1, 0, 0, 1, 0 },
            //                     { 0, 0, 1, 1, 0, 0 },
            //                     { 0, 0, 0, 1, 0, 0 },
            //                     { 0, 0, 0, 0, 1, 1 },
            //                     { 0, 0, 0, 0, 0, 1 },
            //                     { 0, 0, 0, 0, 0, 0 },
            //                };

            //var graph = new Graph(matrix);
            //graph.TestDfs();
            //graph.ShowSort();

            var matrix = new int[56, 56];
            int n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                for (var j = 0; j < input.Length - 1; j++)
                {

                    matrix[input[j] - 65, input[j + 1] - 65] = 1;
                }
            }

            var graph = new Graph(matrix);
            graph.TestDfs();
            graph.ShowSort();
        }
    }
}
