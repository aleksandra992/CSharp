using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PrefixTest
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
                    string[] splitted = line.Split(new char[] { ' ', '.', ',', '!', ':', '\'', '\"', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < splitted.Length; i++)
                    {
                        if (splitted[i].StartsWith("test") == false)
                        {
                            result.Append(splitted[i]);

                            if (i < splitted.Length - 1)
                            {
                                result.Append(' ');
                            }
                        }
                    }
                    result.AppendLine();
                    line = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(outFileName);

            using (writer)
            {
                writer.Write(result.ToString());
            }
        }
    }
}
