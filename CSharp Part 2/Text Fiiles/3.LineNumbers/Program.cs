using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            Console.Write("Enter the output file name: ");
            string fileNameOutput = Console.ReadLine();
            StreamReader reader = new StreamReader(fileName);

            using (reader)
            {
                StreamWriter writer = new StreamWriter(fileNameOutput);

                using (writer)
                {
                    int numberOfLine = 1;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine("{0}. {1}", numberOfLine, line);

                        line = reader.ReadLine();
                        numberOfLine++;
                    }
                }

            }
        }
    }
}
