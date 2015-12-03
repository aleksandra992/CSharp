namespace MatchMaker
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static Dictionary<string, HashSet<string>> vertices = new Dictionary<string, HashSet<string>>();
        private static SortedSet<string> guys = new SortedSet<string>();
        private static HashSet<string> girls = new HashSet<string>();

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string gender = Console.ReadLine();
                int numberOfInterests = int.Parse(Console.ReadLine());
                string[] interests = Console.ReadLine().Split(' ');

                for (int j = 0; j < numberOfInterests; j++)
                {
                    string from;
                    string to;
                    if (gender == "m")
                    {
                        from = name;
                        to = interests[j];
                        guys.Add(from);
                    }
                    else
                    {
                        from = interests[j];
                        to = name;
                        girls.Add(name);
                    }

                    if (!vertices.ContainsKey(from))
                    {
                        vertices[from] = new HashSet<string>();
                    }

                    vertices[from].Add(to);
                }
            }

            var used = new HashSet<string>();
            var matches = new Dictionary<string, int>();
            int bestMatch = 0;
            string bestGuy = string.Empty;
            string bestGirl = string.Empty;

            foreach (var guy in guys)
            {
                used.Clear();
                matches.Clear();
                var nextVertices = new Queue<string>();
                nextVertices.Enqueue(guy);

                while (nextVertices.Count > 0)
                {
                    string current = nextVertices.Dequeue();
                    used.Add(current);

                    if (girls.Contains(current))
                    {
                        if (!matches.ContainsKey(current))
                        {
                            matches[current] = 0;
                        }

                        matches[current]++;
                    }
                    else
                    {
                        if (vertices.ContainsKey(current))
                        {
                            foreach (var item in vertices[current])
                            {
                                if (!used.Contains(item))
                                {
                                    nextVertices.Enqueue(item);
                                }
                            }
                        }
                    }

                    if (matches.ContainsKey(current) && bestMatch < matches[current])
                    {
                        bestGuy = guy;
                        bestGirl = current;
                        bestMatch = matches[current];
                    }
                }
            }

            Console.WriteLine("{0} and {1} have {2} common {3}!", bestGuy, bestGirl, bestMatch, bestMatch == 1 ? "interest" : "interests");
        }
    }
}