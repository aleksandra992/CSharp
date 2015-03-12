using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write(@"Enter the file name:(ex.E:\New folder\file.txt");
            string fileName = Console.ReadLine();
            int lineNumber = 1;

            try
            {
                StreamReader reader = new StreamReader(fileName);

                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 !=0)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }

            catch (OutOfMemoryException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
} 
    

