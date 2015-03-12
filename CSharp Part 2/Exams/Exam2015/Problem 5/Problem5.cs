using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5
{
    class Problem5
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
           
            List<string> lines = new List<string>();
            StringBuilder input = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine().Trim();
                if (str != " ")
                    lines.Add(str);
            }
            StringBuilder resultLeft = new StringBuilder();
            StringBuilder resultRight=new StringBuilder();
            StringBuilder result=new StringBuilder();
            for (int i = 0; i < lines.Count; i++)
            {
                
                    if (lines[i].Contains("static"))
                    {
                        counter = 0;
                        if (result.Length != 0)
                        {
                            result.Append("\n");
                        }
                        for (int j = 0; j < lines[i].Length; j++)
                        {
                            if (char.IsUpper(lines[i][j]) && lines[i][j-1]==' ')
                            {
                                while (lines[i][j] != '(')
                                {
                                    resultLeft.Append(lines[i][j]);
                                    j++;
                                }
                            }

                        }
                        resultLeft.Append(" -> ");
                    }
                    
               
               string pom=string.Empty;
               
                while (i < lines.Count-1 && i>0 && !lines[i + 1].Contains("static"))
                {
                    foreach ( var item in Regex.Matches(lines[i], @"\w+\.\w+"))
                    {
                        counter++;
                        i++;
                        resultRight.Append(" ");
                        resultRight.Append(item.ToString());
                        resultRight.Append(",");
                    }

                }
                if (counter != 0)
                {
                    resultLeft.Append(counter);
                }
               
               
                
                    result.Append(resultLeft);
                    result.Append(" -> ");
                result.Append(resultRight.ToString().TrimEnd(','));
                resultLeft.Clear();
                resultRight.Clear();
            
            }

        }
    }
}
