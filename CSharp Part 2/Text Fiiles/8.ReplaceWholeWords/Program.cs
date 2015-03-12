using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.ReplaceWholeWords
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the file path that you want to replace only whole words:");
            string input = Console.ReadLine();
            Console.Write("Enter the output file name: ");
            string fileName = Console.ReadLine();
            StreamReader ReadFromFile = new StreamReader(input);
            StreamWriter WriteTheResults = new StreamWriter(fileName);
            using (ReadFromFile)
            {
                using (WriteTheResults)
                {
                    string line = ReadFromFile.ReadLine();
                    while (line != null)
                    {
                        string NewLine = Regex.Replace(line, @"\bstart\b", " finish ");
                        WriteTheResults.WriteLine(NewLine);
                        line = ReadFromFile.ReadLine();
                    }
                }
            }
        }
    }
}
