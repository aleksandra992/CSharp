namespace SuperMarketQueue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            BigList<string> queue = new BigList<string>();
            StringBuilder result = new StringBuilder();
            Dictionary<string, int> countNames = new Dictionary<string, int>();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Append":
                        {
                            queue.Add(input[1]);
                            result.AppendLine("OK");
                            if (countNames.ContainsKey(input[1]))
                            {
                                countNames[input[1]]++;
                            }
                            else
                            {
                                countNames.Add(input[1], 1);
                            }
                            break;
                        }

                    case "Serve":
                        {
                            int n = int.Parse(input[1]);
                            if (n > queue.Count)
                            {
                                result.AppendLine("Error");

                            }
                            else
                            {
                                StringBuilder output = new StringBuilder();
                                for (var i = 0; i < n; i++)
                                {
                                    var element = queue[i];
                                    output.Append(element)
                                        .Append(" ");
                                    countNames[element]--;
                                }
                                queue.RemoveRange(0, n);

                                result.AppendLine(output.ToString().TrimEnd(' '));
                            }
                            break;
                        }
                    case "Find":
                        {
                            int numberOfPeople;
                            if (!countNames.ContainsKey(input[1]))
                            {
                                numberOfPeople = 0;
                            }
                            else
                            {
                                numberOfPeople = countNames[input[1]];
                            }

                            result.AppendLine(numberOfPeople.ToString());
                            break;
                        }
                    case "Insert":
                        {
                            int index = int.Parse(input[1]);
                            if (index > queue.Count)
                            {
                                result.AppendLine("Error");
                            }
                            else
                            {
                                queue.Insert(index, input[2]);
                                if (countNames.ContainsKey(input[2]))
                                {
                                    countNames[input[2]]++;
                                }
                                else
                                {
                                    countNames.Add(input[2], 1);
                                }
                                result.AppendLine("OK");
                            }

                            break;
                        }
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(result);
        }
    }
}
