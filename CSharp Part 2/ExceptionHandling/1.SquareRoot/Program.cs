using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SquareRoot
{
    class Program
    {
      
           
           static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive number: ");
                double number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number "+ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
        }
    }

