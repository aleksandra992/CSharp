using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter url");
            string url = Console.ReadLine();
            string protocol = url.Substring(0, url.IndexOf(':'));
            int nextStartIndex=url.IndexOf("//") + 2;
            string server = url.Substring(url.IndexOf("//") + 2, url.IndexOf('/',nextStartIndex ) - url.IndexOf("//") -2);
            string resource = url.Substring(url.IndexOf('/',nextStartIndex) + 1, url.Length -1- url.IndexOf('/',nextStartIndex));
            Console.WriteLine("[protocol]= {0}", protocol);
            Console.WriteLine("[server]= {0}", server);
            Console.WriteLine("[resource]= {0}", resource);
        }
    }
}
