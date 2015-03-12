using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SaveSortedNames
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a path to the input file: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a path to the output file: ");
            string output = Console.ReadLine();
            StreamReader ReadListOfStrings = new StreamReader(input);
            List<string> ListOfNames = new List<string>();
            using (ReadListOfStrings)
            {

                string Current = "";
                while (Current != null)
                {
                    Current = ReadListOfStrings.ReadLine();
                    ListOfNames.Add(Current);
                }

            }
            ListOfNames.Sort();
            StreamWriter WriteSortedNames = new StreamWriter(output);
            using (WriteSortedNames)
            {
                for (int index = 1; index < ListOfNames.Count; index++)
                {
                    WriteSortedNames.WriteLine("{0}. {1}", index, ListOfNames[index]);
                }
            }
        }
    }
}

