using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortByStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string array separated with comma");
            string[] array = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x=>x.Length).ToArray();
          //  Array.Sort(array, new LenghtComparer());
            Console.WriteLine(string.Join(",", array));
            
                
        }
       /* private class LenghtComparer : IComparer<string>
        {
            public int Compare(string firstString, string secondString)
            {
                return (firstString.Length==(int)Math.Max(firstString.Length, secondString.Length)?firstString:secondString);
            }
 
        }
        * */
    }
}
