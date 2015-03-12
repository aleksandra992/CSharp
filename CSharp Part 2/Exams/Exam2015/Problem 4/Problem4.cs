using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Problem4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();
            HashSet<int> input = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                string s;
                commands.Add(s = Console.ReadLine());
                for (int j = 0; j < s.Length; j++)
                {
                    if (char.IsDigit(s[j]))
                    {
                        input.Add(int.Parse(s[j].ToString()));
                    }
                }

            }
            int[] word = new int[input.Count];
            int g = 0;
            foreach (int item in input)
            {
                word[g] = item;
                g++;
            }
            Array.Sort(word);
            if (isValid(word,commands))
            {
                Console.WriteLine(string.Join("", word));
                return;
            }
            while (NextPermutation(word))
            {
                if (isValid(word, commands))
                {
                    
                    Console.WriteLine(string.Join("", word));
                    return;
                }
            }
            Console.WriteLine(string.Join("", word));
        }

        public static bool isValid(int[] word, List<string> com)
        {
            int flag = 0;
            for (int i = 0; i < com.Count; i++)
            {
                string output = Command(com[i]);
                int prv = int.Parse(output[0].ToString());
                int vtor = int.Parse(output[1].ToString());

                if (Array.IndexOf(word, prv) > Array.IndexOf(word, vtor))
                {
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                return true;
            }
            return false;
        }

        public static string Command(string c)
        {
            string s = string.Empty;
            if (c.Contains("is after"))
            {
             
                s += int.Parse(c[c.Length - 1].ToString());
                s += int.Parse(c[0].ToString());
            }
            else
                if (c.Contains("is before"))
                {
                    s += int.Parse(c[0].ToString());
                    s+=int.Parse(c[c.Length - 1].ToString());
                }
            return s;
        }

        //from exam  2013 
        private static bool NextPermutation(int[] array)
        {
            for (int index = array.Length - 2; index >= 0; index--)
            {
                if (array[index] < array[index + 1])
                {
                    int swapWithIndex = array.Length - 1;
                    while (array[index] >= array[swapWithIndex])
                    {
                        swapWithIndex--;
                    }

                    // Swap i-th and j-th elements
                    var tmp = array[index];
                    array[index] = array[swapWithIndex];
                    array[swapWithIndex] = tmp;

                    Array.Reverse(array, index + 1, array.Length - index - 1);
                    return true;
                }
            }

            // No more permutations
            return false;
        }

    }
}
