using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {int a = 5;
            int b = 10;
            Console.WriteLine("a="+a+" and b="+ b);
            
            int hint;
            hint = a;
            a = b;
            b = hint;
           Console.WriteLine("a="+a+" and b="+ b);
          
        }
    }
}
