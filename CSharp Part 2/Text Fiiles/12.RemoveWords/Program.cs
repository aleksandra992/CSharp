using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RemoveWords
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Input words list file path: ");
                string list = Console.ReadLine();
                Console.WriteLine("Input text file path: ");
                string text = Console.ReadLine();
                string fileWithWords = list;
                string fileWithText = text;
                string tempFile = "temp.txt";
                List<string> words = readWords(fileWithWords);
                removeWords(fileWithText, tempFile, words);
                Console.WriteLine("The new file is ready! result is in {0} file", text);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file does not exist!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The caller does not have the required permission!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format!");
            }
        }

        static List<string> readWords(string fileName)
        {
            List<string> words = new List<string>();
            using (StreamReader readFile = new StreamReader(fileName))
            {
                string line = readFile.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = readFile.ReadLine();
                }
            }
            return words;
        }
        static void removeWords(string fileName, string newTextFile, List<string> words)
        {
            using (StreamWriter streamWriter = new StreamWriter(newTextFile))
            {
                using (StreamReader readFile = new StreamReader(fileName))
                {
                    string line = readFile.ReadLine();
                    while (line != null)
                    {
                        for (int j = 0; j < words.Count; j++)
                        {
                            string word = words[j];
                            line = line.Replace(word, "");
                        }
                        streamWriter.WriteLine(line);
                        line = readFile.ReadLine();
                    }
                }
            }
            File.Delete(fileName);
            File.Move(newTextFile, fileName);
        }
    }
}
