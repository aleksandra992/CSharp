using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            string[] sentences = text.Split('.');
            List<string> result = new List<string>();
            List<string> words = new List<string>();
            int flag = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                words= sentences[i].Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in words)
                {
                    if (item == word)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    result.Add(sentences[i]);
                    flag = 0;
                }
            }
            Console.WriteLine(string.Join(".", result.ToArray<string>()));
        }
    }
}
