using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            string newSubStr="[URL=";
            string oldSubStr="<a href=\"";
            Console.WriteLine(oldSubStr);
            int startIndexTag = -1;
            int endIndexTag = 0;
            int startIndexText = 0;
            StringBuilder result = new StringBuilder();
           // startIndexTag = text.IndexOf(oldSubStr, startIndexTag + 1);
            while ((startIndexTag = text.IndexOf(oldSubStr, startIndexTag + 1)) != -1)
            {
                endIndexTag = text.IndexOf('>', startIndexTag);
                result.Append(SubString(text, startIndexText, startIndexTag-1));
                result.Append(newSubStr);
                result.Append(SubString(text, startIndexTag + oldSubStr.Length, endIndexTag-2));
                result.Append("]");
                startIndexText = endIndexTag + 1;


            }
            result.Append(SubString(text, endIndexTag + 1, text.Length - 1));
            result.Replace("</a>", "[/URL]");
            Console.WriteLine(result);


            //var res = Regex.Replace(text, @"<a href=""(.*?)"">",
            //     m =>
            //     {
            //         var codeString = "[URL=" + m.Groups[1].Value + "]";
            //         return codeString;




            //     });
            //res = res.Replace("</a>", "[/URL]");
            //Console.WriteLine(res.ToString());

        }
        static string SubString(string str, int start, int end)
        {
            return str.Substring(start, end - start + 1);
        }
    }
}
