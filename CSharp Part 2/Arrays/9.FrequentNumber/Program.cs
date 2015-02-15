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
            List<int> arrayDifferentNumbers = new List<int>();
            List<int> countNumbers = new List<int>();
          
          /*  while (currentIndex != -1)
            {
                br++;
                lastIndex = Array.IndexOf(array, n, currentIndex + 1);
                currentIndex = lastIndex;
                
            }
           * */
            for (int i = 0; i < array.Length; i++)
            {
                if (!arrayDifferentNumbers.Contains(array[i]))
                {
                    arrayDifferentNumbers.Add(array[i]);
                }
            }
            for (int i = 0; i < arrayDifferentNumbers.Count; i++)
            {
                countNumbers.Add(0);
            }
            int pomIndex;
                for (int i = 0; i < array.Length; i++)
                {
                    pomIndex = arrayDifferentNumbers.IndexOf(array[i]);
                    
                    countNumbers[pomIndex]++;
                }

            
           
            int maxIndex=countNumbers.IndexOf(countNumbers.Max());

            Console.WriteLine("The number {0}({1} times)", arrayDifferentNumbers[maxIndex], countNumbers[maxIndex]);
            Console.ReadKey();
        }
    }

