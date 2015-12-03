namespace SalariesValid
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {

            IDictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
            var n = int.Parse(Console.ReadLine());
            var employees = new int[n];
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                adjacencyList[i] = new List<int>();
                for (var j = 0; j < n; j++)
                {
                    if (input[j] == 'Y')
                    {
                        adjacencyList[i].Add(j);
                    }
                }

                if (adjacencyList[i].Count == 0)
                {
                    employees[i] = 1;
                }
            }
        }

        private static long Calculate(int employeeId, IList<long> employees, IDictionary<int, List<int>> adjacencyList)
        {
            if (employees[employeeId] != 0)
            {
                return employees[employeeId];
            }

            foreach (var employee in adjacencyList[employeeId])
            {
                employees[employeeId] += Calculate(employee, employees, adjacencyList);
            }

            return employees[employeeId];
        }
    }
}
