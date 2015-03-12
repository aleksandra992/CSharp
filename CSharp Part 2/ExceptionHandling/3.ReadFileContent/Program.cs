using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ReadFileContent
{
    class Program
    {
        
             static void Main(string[] args)
        {

            Console.Write("Enter path: ");
            string path = Console.ReadLine();
            try
            {
                StreamReader stream = new StreamReader(path);
                
                    Console.WriteLine(stream.ReadToEnd());
                
            }
            
           
            catch (FileLoadException exception)
            {
                Console.WriteLine("The file cannot be loaded");
            }
            catch (DriveNotFoundException exception)
            {
                Console.WriteLine("The drive cannot be found");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (PathTooLongException exception)
            {
                Console.WriteLine("The path is too long");
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine("That file doesn't exist");
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        
        }
    }
}
