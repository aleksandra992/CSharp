using System;
using System.Threading;

class Enigmation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        string str = Console.ReadLine().TrimEnd(new char[] { '=' }).Trim(' ');
        string[] k = str.Split(new char[] { '(', ')' });
        string[] strNew = {substring(k)};
        Console.WriteLine("{0:0.000}",long.Parse(substring(strNew)));


       

       

      




    }
    static string substring(string[] s)
    {
        
        long finalResult=0;
        string str;
        long digit;
        char operand=' ';
        string resultString = "";
        long pom=0;
        for (int h = 0; h < s.Length; h++)
        {
         str=s[h];

         if (char.IsDigit(s[h][0]) && char.IsDigit(s[h][str.Length-1]))
         {
             for (int i = 0; i < s[h].Length; i++)
             {
                 if (long.TryParse(s[h][i].ToString(), out digit))
                 {
                    
                     if (operand != ' ')
                     {
                         while(i<s[h].Length && char.IsDigit(s[h][i]))
                         {
                             i++;
                             pom = pom * 10 + digit;

                             continue;
                         }
                         i--;

                         switch (operand)
                         {
                             case '+':
                                 {

                                     finalResult += pom;
                                     pom = 0;
                                     break;
                                 }
                             case '-':
                                 {

                                     finalResult -= pom;
                                     pom = 0;
                                     break;

                                 }
                             case '*':
                                 {
                                     finalResult *= pom;
                                     pom = 0;
                                     break;
                                 }
                             case '%':
                                 {

                                     finalResult %= pom;
                                     pom = 0;
                                     break;
                                 }

                         }
                     }
                     else
                     {
                         finalResult =finalResult*10+digit;
                     }

                 }
                 else
                 {
                     if (s[h][i] == '%' || s[h][i] == '-' || s[h][i] == '+' || s[h][i] == '*')
                     operand = s[h][i];
                 }




             }

             resultString += finalResult.ToString();

         }
         else
             resultString += s[h];

           
        }

        return resultString;

    }
}

