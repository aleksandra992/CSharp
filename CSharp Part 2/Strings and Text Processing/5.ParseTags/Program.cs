using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter text");
            string str = Console.ReadLine();

            string subStr1 = "<upcase>";
            string subStr2 = "</upcase>";
            int startIndexUpper = 0;
            int startIndex = 0;
            int endIndexUpper = 0;
            int startIndexFirstTag = 0;
            int startIndexSecondTag = 0;
            StringBuilder result = new StringBuilder();
            while (str.IndexOf(subStr1, startIndex) != -1)
            {
                startIndexUpper = (startIndexFirstTag = str.IndexOf(subStr1, startIndex)) + subStr1.Length;
                endIndexUpper = str.IndexOf(subStr2, startIndexUpper) - 1;
                result.Append(str.Substring(startIndex, startIndexFirstTag - startIndex));
                result.Append(str.Substring(startIndexUpper, endIndexUpper - startIndexUpper + 1).ToUpper());
                startIndex = endIndexUpper + subStr2.Length + 1;


            }

            if (startIndex <= str.Length - 1)
            {
                result.Append(str.Substring(startIndex, str.Length - startIndex));

            }
            Console.WriteLine(result.ToString());

            //var res = Regex.Replace(str, @"<upcase>(.*?)</upcase>",
            //     m =>
            //     {
            //         var codeString = m.Groups[1].Value;
            //         return codeString.ToUpper();




            //     });
            //Console.WriteLine(res.ToString());



        }

    }
}
