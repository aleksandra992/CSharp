using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.ExtractTextFromXML
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input file path: ");
            string inputFile = Console.ReadLine();
            Console.WriteLine("Input file path: ");
            string output = Console.ReadLine();
            StreamReader ReadWebsite = new StreamReader(inputFile);
            StreamWriter ExtractContent = new StreamWriter(output);
            string pattern = @">(.*?)\<";
            using (ReadWebsite)
            {
                using (ExtractContent)
                {
                    string line = ReadWebsite.ReadLine();
                    while (line != null)
                    {
                        Regex content = new Regex(pattern);
                        MatchCollection result = content.Matches(line);
                        foreach (var Line in result)
                        {
                            ExtractContent.WriteLine(Line);
                            Console.WriteLine(Line);
                        }
                        line = ReadWebsite.ReadLine();
                    }
                }
            }
        }
    }
}
