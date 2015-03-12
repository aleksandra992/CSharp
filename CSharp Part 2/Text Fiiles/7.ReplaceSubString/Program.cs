using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReplaceSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter the output file name: ");
            string outFileName = Console.ReadLine();
            
    
        StreamReader reader = new StreamReader(fileName);
        StringBuilder result = new StringBuilder();

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                result.AppendLine(line);
                line = reader.ReadLine();
            }
        }
        result.Replace("start", "finish");

        StreamWriter writer = new StreamWriter(outFileName);
        using (writer)
        {
            writer.Write(result.ToString());
        }
    }
        
    }
}
