using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add(".NET", "platform for applications from Microsoft");
            words.Add("CLR", "managed execution environment for .NET");
            words.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Enter .NET, CLR or namespace");
            string key = Console.ReadLine();
            string result=string.Empty;
            result=words[key];
            //words.TryGetValue(key, out result);
            Console.WriteLine(result);
        }
    }
}
