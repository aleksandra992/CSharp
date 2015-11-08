using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Data_Structures
{
    public class Startup
    {
        public static void Main()
        {
            var queue = new BinaryHeap<string>(new Comparison<string>(Compare));
            queue.Insert("c");
            queue.Insert("a");
            queue.Insert("b");

            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());


        }
        public static int Compare(string a,string b)
        {
            return a.CompareTo(b);
        }
    }
}
