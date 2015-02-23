using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9.ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text");
            string text = Console.ReadLine();
            Console.WriteLine("enter the forbbiden words");
            string[] forbbidenWords = Console.ReadLine().Split(' ');
            List<string> sentences = text.Split('.').ToList();
            List<string> words = new List<string>();
            
            for (int i = 0; i < sentences.Count; i++)
            {
                words = sentences[i].Split(' ').ToList();
                for (int j = 0; j < words.Count;j++)
                {
                    if (forbbidenWords.Contains(words[j]))
                    {
                        words[j] = new string('*', words[j].Length);
                    }

                }
                sentences[i]=string.Join(" ",words);
               
            }
            Console.WriteLine(string.Join(".", sentences.ToArray<string>()));

            //var res = Regex.Replace(text,string.Join("|", forbbidenWords.ToArray()),
            //     m =>
            //     {
            //         var length = m.Length;
            //         return new string('*', length);




            //     });
            //Console.WriteLine(res.ToString());
        }
    }
}
