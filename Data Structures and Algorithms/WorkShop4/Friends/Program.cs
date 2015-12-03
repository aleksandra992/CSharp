namespace Friends
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static int start;
        private static int end;
        private static int middle1;
        private static int middle2;
        private static int n;
        private static int m;
        private static List<Node>[] graph;

        public static void Main()
        {
            ReadInput();

            var best = Solve();

            Console.WriteLine(best);
        }

        private static int Solve()
        {
            var middle1Distances = FindPathDijkstra(middle1, new int[] { start, end, middle2 });
            var middle2Distances = FindPathDijkstra(middle2, new int[] { start, end, middle1 });

            int middle1ToStartDistance = middle1Distances[start];
            int middle2ToStartDistance = middle2Distances[start];

            int middle1ToEndDistance = middle1Distances[end];
            int middle2ToEndDistance = middle2Distances[end];

            int middle1ToMiddle2Distance = middle1Distances[middle2];
            int middle2ToMiddle1Distance = middle2Distances[middle1];

            var firstPossiblePath = middle1ToStartDistance + middle1ToMiddle2Distance + middle2ToEndDistance;
            var secondPossiblePath = middle2ToStartDistance + middle2ToMiddle1Distance + middle1ToEndDistance;

            var best = Math.Min(firstPossiblePath, secondPossiblePath);

            return best;
        }

        private static int[] FindPathDijkstra(int from, int[] skip)
        {
            // dijkstra
            int firstNodeLabel = from;
            int[] distances = new int[n].Select(d => int.MaxValue).ToArray();
            var queue = new SortedSet<Node>();
            var visited = new HashSet<int>();


            foreach (var nodeLabel in skip)
            {
                visited.Add(nodeLabel);
            }

            distances[firstNodeLabel] = 0;
            queue.Add(new Node(firstNodeLabel, 0));

            while (queue.Count > 0)
            {
                var current = queue.First();
                queue.Remove(current);
                visited.Add(current.Label);

                // calculate distance
                foreach (var neighbour in graph[current.Label])
                {
                    var currentDistance = distances[neighbour.Label];
                    var newDistance = distances[current.Label] + neighbour.Weight;
                    if (currentDistance > newDistance)
                    {
                        // new solution better than the previous
                        distances[neighbour.Label] = newDistance;
                        queue.Add(new Node(neighbour.Label, newDistance));
                    }
                }

                // remove top visited from queue //current?
                while (queue.Count > 0 && visited.Contains(queue.First().Label))
                {
                    queue.Remove(queue.First());
                }

            }

            return distances;
        }

        private static void ReadInput()
        {
            var counts = GetConsoleLine();
            n = counts[0];
            m = counts[1];

            var endPoints = GetConsoleLine();
            start = endPoints[0] - 1;
            end = endPoints[1] - 1;

            var middlePoints = GetConsoleLine();
            middle1 = middlePoints[0] - 1;
            middle2 = middlePoints[1] - 1;

            graph = new List<Node>[n];
            for (int i = 0; i < m; i++)
            {
                var edge = GetConsoleLine();

                var from = edge[0] - 1;
                var to = edge[1] - 1;
                var weight = edge[2];

                if (graph[from] == null)
                {
                    graph[from] = new List<Node>();
                }

                if (graph[to] == null)
                {
                    graph[to] = new List<Node>();
                }

                graph[from].Add(new Node(to, weight));
                graph[to].Add(new Node(from, weight));
            }
        }

        private static int[] GetConsoleLine()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }

    public class Node : IComparable<Node>
    {
        public Node(int label, int weight)
        {
            this.Label = label;
            this.Weight = weight;
        }

        public int Label { get; set; }

        public int Weight { get; set; }

        public int CompareTo(Node other)
        {
            if (this.Weight.CompareTo(other.Weight) == 0)
            {
                return this.Label.CompareTo(other.Label);
            }

            return this.Weight.CompareTo(other.Weight);
        }
    }
}