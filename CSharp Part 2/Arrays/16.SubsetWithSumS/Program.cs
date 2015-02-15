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
            Console.WriteLine("Enter sum");
         /*   int offset =(-1)*array.Min();

            int sum = int.Parse(Console.ReadLine());
            int sumPozitive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sumPozitive += array[i];
                }
                
            }
            int []previousSums = new int[sumPozitive+offset+1];
            int[] currentSums = new int[previousSums.Length];
            previousSums[(array[0]+offset)]=1;



            for(int k=1;k<array.Length;k++)
            {
                for(int i=0;i<previousSums.Length;i++)
                {
                    if (previousSums[i] == 1)
                    {
                        currentSums[i] = 1;
                        currentSums[array[k]-offset + i] = 1;
                        
                    }
                }
                currentSums[array[k]-offset] = 1;
                previousSums = currentSums;
                currentSums=new  int[previousSums.Length];

            
            }
            if (sum <=sumPozitive )
            {
                if (previousSums[sum - offset] == 1)
                {
                    Console.Write("yes");
                }
                else
                    Console.WriteLine("no");
            }
            else
                Console.WriteLine("no");
            Console.ReadKey();
            */
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
            //Console.ReadKey();


        }
    }

