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
            int minElement = array[0],minPosition=0;
            int hint = 0;
            for (int i = 0; i < array.Length; i++)
            {
                minElement = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j]<minElement)
                    {
                        minElement = array[j];
                        minPosition = j;
                    }
                }
                hint = array[i];
                array[i] = minElement;
                array[minPosition] = hint;
                
            }
            Console.WriteLine(string.Join(",", array));
        }
    }

