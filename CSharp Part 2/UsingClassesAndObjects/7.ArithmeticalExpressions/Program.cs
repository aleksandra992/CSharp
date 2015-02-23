using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.ArithmeticalExpressions
{
    class Program
    {
        static void Main()
        {
            Console.Write("Add some  math expression :");
            string s = Console.ReadLine();

            s = s.Replace(" ", "");


            var res = Regex.Replace(s, @"ln\([+-]?(\d*\.?\d*)\)",
                 m =>
                 {
                     var codeString = m.Groups[0].Value;
                     int indexStart = codeString.IndexOf('(');
                     int indexEnd = codeString.IndexOf(')', indexStart + 1);

                     codeString = codeString.Substring(indexStart + 1, indexEnd - indexStart - 1);

                     double p = double.Parse(codeString);

                     return Math.Log((double)p, Math.Exp(1)).ToString();

                 });

            res = Regex.Replace(res, @"sqrt\([+-]?(\d*\.?\d*)\)",
                m =>
                {
                    var codeString = m.Groups[0].Value;
                    int indexStart = codeString.IndexOf('(');
                    int indexEnd = codeString.IndexOf(')', indexStart + 1);

                    codeString = codeString.Substring(indexStart + 1, indexEnd - indexStart - 1);

                    double p = double.Parse(codeString);

                    return Math.Sqrt(p).ToString();

                });
            res = Regex.Replace(res, @"pow\([+-]?(\d*\.?\d*),[+-]?(\d*\.?\d*)\)",
                   m =>
                   {
                       var codeString = m.Groups[0].Value;
                       int indexStart = codeString.IndexOf('(');
                       int indexEnd = codeString.IndexOf(')', indexStart + 1);

                       codeString = codeString.Substring(indexStart + 1, indexEnd - indexStart - 1);

                       string[] numbers = codeString.Split(',');
                       double firstNum = double.Parse(numbers[0]);
                       double secondNum = double.Parse(numbers[1]);


                       return Math.Pow(firstNum, secondNum).ToString();

                   });


            DataTable dt = new DataTable();
            var v = dt.Compute(res, "");
            Console.WriteLine(v);
        }

    }
}
