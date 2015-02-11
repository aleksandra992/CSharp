using System;

class Program
{
    static void Main()
        {
            long n=long.Parse(Console.ReadLine());
            string s = Convert.ToString(n, 2).PadLeft(16,'0');
            string newString = s.Substring(s.Length - 16, 16);
            string finalString = "";
        string strForOne1=".#.";
        string strForZero1="###";
        string strForOne2="##.";
        string strForZero2="#.#";
        int flag = 0;
        
            for (int i = 0; i < 5; i++)
            {
                finalString="";
                if(i==0)
                {
                
                for (int j = 0; j < 16; j++)
                {
                    if (newString[j] == '1')
                    {
                        
                        finalString += ((finalString.Length==0)?"":".") + strForOne1;
                    }
                    else
                        finalString += ((finalString.Length == 0) ? "" : ".") + strForZero1;
                }
                Console.WriteLine(finalString);
                }
                else
                    
                    if (i == 1)
                    {
                        for (int j = 0; j < 16; j++)
                        {
                            if (newString[j] == '1')
                            {

                                finalString += ((finalString.Length == 0) ? "" : ".") + strForOne2;
                            }
                            else
                                finalString += ((finalString.Length == 0) ? "" : ".") + strForZero2;
                        }
                        Console.WriteLine(finalString);
                    }
                    else

                        if (i == 4)
                        {
                            for (int j = 0; j < 16; j++)
                            {
                                if (newString[j] == '1')
                                {

                                    finalString += ((finalString.Length == 0) ? "" : ".") + strForZero1;
                                }
                                else
                                    finalString += ((finalString.Length == 0) ? "" : ".") + strForZero1;
                            }
                            Console.WriteLine(finalString);
                        }
                        else
                        {
                            for (int j = 0; j < 16; j++)
                            {
                                if (newString[j] == '1')
                                {

                                    finalString += ((finalString.Length == 0) ? "" : ".") + strForOne1;
                                }
                                else
                                    finalString += ((finalString.Length == 0) ? "" : ".") + strForZero2;
                            }
                            Console.WriteLine(finalString);
                        }


                
            }

        }
}

