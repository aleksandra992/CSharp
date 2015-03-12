using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string indent = Console.ReadLine();
            List<string> lines = new List<string>();
            StringBuilder input=new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                string str = Console.ReadLine().Trim();
                if(str!=" ")
                lines.Add(str);
            }

            int numberIndent = 0;
            StringBuilder result = new StringBuilder();
            int pom = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    if (lines[i][j] == '{')
                    {
                        if (result.Length > 1)
                        {
                            if (result[result.Length - 1] != '\n')
                            {
                                result.Append('\n');
                            }
                        }
                            result.Append(Indent(indent, numberIndent));
                            pom = numberIndent;
                            result.Append('{');
                            result.Append("\n");
                            numberIndent++;
 
                        
                        
                    }
                    else
                    if (lines[i][j] == '}')
                    {
                        numberIndent--;
                        if(result[result.Length-1]=='\n')
                        {
                            result.Append(Indent(indent, numberIndent)).Append('}').Append('\n');
                        }
                        else
                        result.Append('\n').Append(Indent(indent, numberIndent)).Append('}').Append('\n');
                    }
                    else
                    {
                        if (lines[i][j] == ' ')
                        {
                            if (result[result.Length - 1] != '\n')
                            {
                                result.Append(' ');
                            }
                            while (lines[i][j] == ' ' && j<lines[i].Length)
                            {
                                j++;
                                continue;
                            }
                            j--;
                        }
                        else
                            if(lines[i][j]=='\n')
                            {
                                result.Append('\n');
                               // result.Append(Indent(indent, numberIndent));
                            }
                        else
                        {
                            if (result.Length > 0)
                            {
                                if (result[result.Length - 1] == '\n')
                                {
                                    result.Append(Indent(indent, numberIndent));

                                }
                            }
                            result.Append(lines[i][j]);
                        }
                    }

                }
                if (result[result.Length - 1] != '\n')
                result.Append('\n');

            }
            Console.Write(result.ToString().Trim('\n'));
           
        }

        private static string  Indent(string indent, int numberIndent)
        {
            StringBuilder result=new StringBuilder();
            for (int k = 0; k < numberIndent; k++)
            {
                result.Append(indent);
            }
            return result.ToString();
        }
    }
}
