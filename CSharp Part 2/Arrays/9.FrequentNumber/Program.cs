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
            
           
          /*  while (currentIndex != -1)
            {
                br++;
                lastIndex = Array.IndexOf(array, n, currentIndex + 1);
                currentIndex = lastIndex;
                
            }
           * */
            int n = array.Max();
            int[] hint = new int[n];
            for (int i = 0; i < hint.Length; i++)
            {
                hint[i] = 0;
            }
                for (int i = 0; i < array.Length; i++)
                {
                    hint[array[i]-1]++;
                }
                Console.WriteLine("The number {0}({1} times)",Array.IndexOf(hint,hint.Max())+1,hint.Max());

        }
    }

