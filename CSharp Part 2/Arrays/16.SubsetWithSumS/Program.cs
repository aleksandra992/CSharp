using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter the first integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("Enter n");
            int n=int.Parse(Console.ReadLine());
            int numCombinations =(int) Math.Pow(2,array.Length);
            string s = "";
            int sum = 0;
            for(int i=0;i<numCombinations;i++)
            {
                s = Convert.ToString(i, 2).PadLeft(array.Length, '0');
                for (int j = 0; j < array.Length; j++)
                {
                    sum += array[j] * int.Parse(s[j].ToString());
                }
                if (sum == n)
                {
                    Console.WriteLine("yes");
                    return;
                }
                sum = 0;
            }
            Console.WriteLine("no");

        }
    }

