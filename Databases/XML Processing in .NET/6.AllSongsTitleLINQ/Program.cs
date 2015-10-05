using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllSongsTitleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument doc = XDocument.Load("../../../catalogue.xml");
            var albums = doc.Descendants("catalogue").Elements("album");
            var titles =
                from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }

        }
    }
}
