using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompareTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first file name: ");
            string firstFileName = Console.ReadLine();
            Console.Write("Enter the second file name: ");
            string secondFileName = Console.ReadLine();
            using (StreamReader readerOne = new StreamReader(firstFileName))
            {
                using (StreamReader readerTwo = new StreamReader(secondFileName))
                {
                    int equalLines = 0;
                    int differentLine = 0;

                    string firstTextLine = readerOne.ReadLine();
                    string secondTextLine = readerTwo.ReadLine();

                    while (firstTextLine != null && secondTextLine != null)
                    {
                        if (firstTextLine == secondTextLine)
                        {
                            equalLines++;
                        }
                        else
                        {
                            differentLine++;
                        }

                        firstTextLine = readerOne.ReadLine();
                        secondTextLine = readerTwo.ReadLine();
                    }

                    Console.WriteLine("There are {0} equal lines", equalLines);
                    Console.WriteLine("And {0} different line", differentLine);
                }
            }
        }
    }
}
