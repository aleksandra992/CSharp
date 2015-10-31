using System;
using System.Collections.Generic;

namespace MajorantOfArray
{
    public class Startup
    {
        public static void Main()
        {
            string input;
            var numbers = new List<int>();
            Console.WriteLine("Enter numbers each on a separate line");
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                numbers.Add(int.Parse(input));
            }

            Dictionary<int, int> occurences = new Dictionary<int, int>();
            int majorant = 0;
            bool flag = false;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (occurences.ContainsKey(numbers[i]))
                {
                    occurences[numbers[i]]++;
                }
                else
                {
                    occurences[numbers[i]] = 1;
                }

                if (occurences[numbers[i]] >= numbers.Count / 2 + 1)
                {
                    majorant = numbers[i];
                    flag = true;
                    break;
                }

            }
            if (flag == true)
            {
                Console.WriteLine("The majorant is {0} ", majorant);
            }
            else
            {
                Console.WriteLine("No majorant in this array");
            }

        }
    }
}
