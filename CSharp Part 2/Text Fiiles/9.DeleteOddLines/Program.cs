using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.DeleteOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();
            StreamReader reader = new StreamReader(fileName);
            StringBuilder result = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                int count = 0;


                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        result.AppendLine(line);
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }

            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.Write(result.ToString());
            }
        }
    }
}
