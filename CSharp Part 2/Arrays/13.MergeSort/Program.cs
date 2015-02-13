using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer array separated with comma");
            int[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            MergeSort(array,0,array.Length-1);
            Console.WriteLine(string.Join(",",array));
        }
        static void MergeSort(int[] elements, int start, int end)
        {
            if(start==end)
            {
                return;
            }
            int mid = (start + end) / 2;
            MergeSort(elements, mid + 1, end);
            MergeSort(elements, start, mid);
            Merge(elements, start, mid, end);
        }
        static void Merge(int[] elements, int start, int mid, int end)
        {
            int numel = end - start + 1;
            int[] temp = new int[100];
            int i, j, k = 0;
            i=start;
            j=mid+1;
            while ((i <= mid) && (j <= end))
            {
                if (elements[i] < elements[j])
                {
                    temp[k++] = elements[i++];
                }
                else
                    temp[k++] = elements[j++];
            }
            while(i<=mid)
                temp[k++]=elements[i++];
            while(j<=end)
                temp[k++]=elements[j++];
            for(k=0;k<numel;k++)
            {
                elements[start+k]=temp[k];
            }
            }
            
        }
    }

