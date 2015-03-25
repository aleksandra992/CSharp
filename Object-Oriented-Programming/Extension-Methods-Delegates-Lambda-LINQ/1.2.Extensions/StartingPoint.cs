namespace Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Extensions.IEnumerableExtensions;
    using Extensions.StringBuilderExtensions;

    public class StartingPoint
    {
        public static void Main()
        {
            StringBuilder str = new StringBuilder();
            int index = 3;
            int length = 5;
            str.Append("aaabbbvvvggg");
            Console.WriteLine("The substring from index  {0} with lenght {1} is {2}", index, length, str.Substring(index, length));

            List<int> s = new List<int>();

            s.Add(1);
            s.Add(2);
            s.Add(3);
            s.Add(4);
            Console.WriteLine("The sum of {1} is {0}", s.Sum(), string.Join(" ", s.ToArray()));
            Console.WriteLine("The max of {1} is {0}", s.Max(), string.Join(" ", s.ToArray()));
            Console.WriteLine("The average of {1} is {0}", s.Average(), string.Join(" ", s.ToArray()));
            Console.WriteLine("The product of {1} is {0}", s.Product(), string.Join(" ", s.ToArray()));
        }
    }
}
