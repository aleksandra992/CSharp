using System;


namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? first = null;
           double? second = null;
           Console.WriteLine(first);
           Console.WriteLine(second);
           int? result1 = first + 5;
           double? result2 = second + null;
           Console.WriteLine(first);
           Console.WriteLine(second);
           
        }
    }
}
