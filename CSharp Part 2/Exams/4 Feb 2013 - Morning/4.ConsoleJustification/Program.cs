using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ConsoleJustification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInitialLines = int.Parse(Console.ReadLine());
            int numberOfLineSymbols = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            List<string> hint = new List<string>();
            for (int i = 0; i < numberOfInitialLines; i++)
            {
                string[] str=Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToArray();
               for(int j=0;j<str.Length;j++)
               {
                words.Add(str[j]);
               }
 
            }
            int everyGap = 0;
            int firstGaps = 0;
            int numSymbols=0;
            StringBuilder result = new StringBuilder();
            int numWords = 0;
            StringBuilder meguResult=new StringBuilder();
            for (int i = 0; i < words.Count; i++)
            {
                numSymbols+=words[i].Length;
                numWords++;
                if (numSymbols + numWords - 1 <= numberOfLineSymbols)
                {
                    hint.Add(words[i]);
                }
                else
                {

                    numSymbols -= words[i].Length;
                    numWords--;
                    i--;
                    everyGap = (numberOfLineSymbols - numSymbols) / (numWords == 1 ? numWords : (numWords - 1));
                    firstGaps = (numberOfLineSymbols - numSymbols) % (numWords == 1 ? numWords : (numWords - 1));
                    for (int j = 0; j < hint.Count; j++)
                    {
                        
                            if (firstGaps != 0)
                            {
                                meguResult.Append(hint[j] + new String(' ', everyGap) + ' ');
                                firstGaps--;
                            }
                            else
                            {
                                meguResult.Append(hint[j] + new String(' ', everyGap));
                            }
                        
                       
                    }
                    if (meguResult.Length > numberOfLineSymbols || hint.Count == 1)
                    {
                        result.Append(meguResult.ToString().TrimEnd(' ')).Append("\n");
                    }
                    else
                    result.Append(meguResult).Append("\n");

                    meguResult.Clear();
                    numSymbols = 0;
                    hint.Clear();
                    numWords = 0;
                }

                
 
            }

            if (hint.Count != 0)
            {
                everyGap = (numberOfLineSymbols - numSymbols) /(numWords==1?numWords: (numWords - 1));
                firstGaps = (numberOfLineSymbols - numSymbols) % (numWords == 1 ? numWords : (numWords - 1));
                for (int j = 0; j < hint.Count; j++)
                {

                    if (firstGaps != 0)
                    {
                        meguResult.Append(hint[j] + new String(' ', everyGap) + ' ');
                        firstGaps--;
                    }
                    else
                    {
                        meguResult.Append(hint[j] + new String(' ', everyGap));
                    }
                }

                    if (meguResult.Length > numberOfLineSymbols || hint.Count == 1)
                    {
                        result.Append(meguResult.ToString().TrimEnd(' ')).Append("\n");
                    }
                    else
                    {
                        result.Append(meguResult).Append("\n");
                    }

                  

                
                    

                
                
 
            }
            Console.Write(result);

        }
    }
}
