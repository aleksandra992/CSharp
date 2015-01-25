using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            char symbol = (char)169;
              int n = int.Parse(Console.ReadLine());
            int j =1;
            int m=0;

            string s1, s2;

            for(int i=n;i>1;i--)
            {
                s1 = new String(' ', i - 1);
                s2 = new String(' ', j);

                if (i == n)
                {
                    Console.WriteLine(s1 + symbol + s1);
                   
                }
                else
                {
                    Console.WriteLine(s1 + symbol + s2 + symbol + s1);
                    m++;
                    j = (2*m) + 1;
                   
                    
                }

            }

            s1 = new String(symbol,(n*2) -1);
            Console.WriteLine(s1);
        

        }
    }
}
