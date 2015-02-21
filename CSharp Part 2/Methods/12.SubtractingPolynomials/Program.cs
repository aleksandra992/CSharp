using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractingPolynomials
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
            List<int> resultSub = new List<int>();
            resultSub = SubstractPolynomials(firstPolynomial, secondPolynomial);
            Console.Write("The difference between the polynomials is "+string.Join(",", resultSub));
            
            int[] resultMultiple=MultiplePolynomials(firstPolynomial,secondPolynomial);
            int i = 0;
            while (resultMultiple[i] == 0)
            {
                
                i++;
            }
        
          int[] newRes = resultMultiple.Where(x => Array.IndexOf(resultMultiple,x) >= i).ToArray();
                Console.Write("The multiplication of the polynomials is " + string.Join(" ", newRes));
              Console.ReadKey();


        }
        static List<int> SubstractPolynomials(List<int> first, List<int> second)
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
            for (i = 0; i < length; i++)
            {
                result.Add(first[i] - second[i]);
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
        static int[] MultiplePolynomials(List<int> first, List<int> second)
        {
           //veke se reverse od gore

           
            int[] result = new int[second.Count*first.Count];
            int i;
            for (i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    int pom = first[i] * second[j];
                    result[i + j] = result[i +j] + pom;
                }
            }
           
           return result.AsEnumerable().Reverse().ToArray();
           
        }
    }
}
