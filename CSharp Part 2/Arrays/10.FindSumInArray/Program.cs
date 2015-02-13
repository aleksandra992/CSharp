using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            Console.WriteLine("enter the sum");
            int sum =int.Parse( Console.ReadLine());
            int tempSum = 0;
            List<int>sequence=new List<int>();
            StringBuilder str = new StringBuilder("There is no sequence that has that sum");
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    tempSum += array[j];
                    sequence.Add(array[j]);

                    if (tempSum > sum)
                    {
                        tempSum = 0;
                        sequence.Clear();
                        break;
                    }
                    if (tempSum == sum)
                    {
                        str.Clear().Append(string.Join(",", sequence));
                        flag = 1;
                        break;
                    }
                }
                if (flag == 1)
                {
                    break;
                }
            }
            Console.WriteLine(str);
        }
    }
}
