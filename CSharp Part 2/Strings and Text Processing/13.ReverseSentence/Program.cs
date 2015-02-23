using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the text");
            string text = Console.ReadLine();
            char lastSign=text[text.Length-1];
           text= text.TrimEnd(lastSign);
           List<int> positionCommas = positionSignsAsWords(text, ',');
           List<int> positionTwoPoints = positionSignsAsWords(text, ':');
           List<int> positionTire = positionSignsAsWords(text, '-');

            
           List<string> words = text.Split(new char[] { ' ', ',', ':','-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
           words.Reverse();
            StringBuilder result=new StringBuilder();
           for (int i = 0; i < words.Count; i++)
           {
               if (positionCommas.Contains(i))
               {
                   result.Append(",");
               }
               if (positionTwoPoints.Contains(i))
               {
                   result.Append(":");
               }
               if (positionTire.Contains(i))
               {
                   result.Append("-");
               }
               result.Append(" " + words[i]);
           }
           result.Append(lastSign);
          Console.WriteLine( result.ToString().TrimStart(' '));
           
        }


        private static List<int> positionSignsAsWords(string text,char sign)
        {
            List<string> sentences = text.Split(sign).ToList();
            List<string> words = new List<string>();
            List<int> signPositions= new List<int>();
            for (int i = 0; i < sentences.Count; i++)
            {
                if (i != sentences.Count - 1)
                {
                    words = sentences[i].Split(' ').ToList();
                    signPositions.Add(words.Count);
                }
            }
            return signPositions;
        }
    }
}
