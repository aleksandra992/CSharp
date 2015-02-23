using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.ExtractTextFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the html code in one line");
            string sample=@"<html> <head><title>News</title></head> <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>""";
            
           
            var result=Regex.Replace(sample,"<title>(.*?)</title>",
                m=>
                {
                    var str="Title: "+m.Groups[1].Value+"\nText: ";
                    return str;
                }
                );
            Regex reg = new Regex("<[^>]+>", RegexOptions.IgnoreCase);
           result=reg.Replace(result, " ");
           string[] rez = result.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
           Console.WriteLine(string.Join(" ",rez));
           
            }
    }
}
