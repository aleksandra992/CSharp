using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first polynomial coeficients separated with comma");
            List<int> firstPolynomial = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToList();
            Console.WriteLine("Enter the second polynomial coeficients separated with comma");
            List<int> secondPolynomial = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToList();
            List<int> result = new List<int>();
            result = AddPolynomials(firstPolynomial, secondPolynomial);
            Console.Write(string.Join(",", result));
          //  Console.ReadKey();

        }
        static List<int> AddPolynomials(List<int> first, List<int> second)
        {
            first.Reverse();
            second.Reverse();
            List<int> result = new List<int>();
            int length = 0;
            if (first.Count < second.Count)
            {
                length = first.Count;
            }
            else
                length = second.Count;
            int i;
            for ( i = 0; i < length; i++)
            {
                result.Add(first[i] + second[i]);
            }
            while (i < first.Count)
            {
                result.Add(first[i]);
                i++;
            }
            while (i < second.Count)
            {
                result.Add(second[i]);
                i++;
            }
             result.Reverse();
             return result;
        }
    }
}
