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
            int tempSum = 0,maxSum=0;
            List<int> sequence=new List<int>();
            StringBuilder str = new StringBuilder();
            if(array.Max()<0)
            {
                Console.WriteLine(array.Max());
                return;
            }
            if (array.Min() > 0)
            {
                Console.WriteLine(string.Join(",", array));
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                
                tempSum+=array[i];
                sequence.Add(array[i]);
                if (tempSum <= 0)
                {
                    tempSum = 0;
                    sequence.Clear();


                }
                else
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        //sequence.Add(array[i]);
                      str.Clear().Append(string.Join(",", sequence));


                    }
                    
                        
                
               

            }
           // Console.WriteLine(str);
            Console.WriteLine(string.Join(",",sequence));
            Console.WriteLine(maxSum);
            Console.ReadKey();
        }
    }

