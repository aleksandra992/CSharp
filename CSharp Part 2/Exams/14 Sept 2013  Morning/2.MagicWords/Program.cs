using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            string pom = string.Empty;
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());

            }
            int position = 0;

            for (int i = 0; i < words.Count; i++)
            {
                pom = words[i];
                position = words[i].Length % (n + 1);
                words[i] = null;
                words.Insert(position, pom);

                words.Remove(null);


            }
            Console.WriteLine(MagicPrint(words));
        }
        static string MagicPrint(List<string> words)
        {
            int maxLenght = int.MinValue;
            foreach (var item in words)
            {
                if (item.Length > maxLenght)
                {
                    maxLenght = item.Length;
                }

            }
            char bukva = '\0';
            int k = 0;
            StringBuilder result = new StringBuilder();
            while (maxLenght >= 0)
            {

                for (int i = 0; i < words.Count; i++)
                {
                    if (k > words[i].Length - 1)
                    {
                        continue;
                    }
                    bukva = words[i][k];
                    result.Append(words[i][k]);

                }
                k++;
                maxLenght--;
            }

            return result.ToString();


        }


    }
}
