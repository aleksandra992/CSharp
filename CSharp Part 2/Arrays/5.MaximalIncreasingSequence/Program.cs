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
            int maxLenght=0,bestElement=0,tempElement=array[0],tempLenght=1,position=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == tempElement + 1)
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
                    position=i;
                }
                tempElement = array[i];
            }
            int newPosition = position - maxLenght + 1;
            array = array.Skip(newPosition).Take(maxLenght).ToArray();
            Console.WriteLine(string.Join(",", array));
        }
    }

