using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInString
{
    class QuotesInString
    {
        static void Main()
        {
            string first="The \"use\" of quotations causes difficulties.";
            string second=@"The ""use"" of quotations causes difficulties";
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
