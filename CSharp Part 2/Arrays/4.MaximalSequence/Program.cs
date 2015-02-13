using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            int maxLenght = 0, tempLenght = 1,tempElement=array[0],bestElement=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == tempElement)
                {
                    tempLenght++;
                }
                else
                {
                    tempLenght = 1;
                   
                }
                if (tempLenght > maxLenght)
                {
                    maxLenght = tempLenght;
                    bestElement = tempElement;
                   
                    
                }
                tempElement = array[i];
            }
            array = Enumerable.Range(0, maxLenght).Select(x => bestElement).ToArray();
            Console.WriteLine(string.Join(",", array));

        }
    }

