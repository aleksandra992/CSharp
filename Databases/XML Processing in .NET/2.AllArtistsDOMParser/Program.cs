using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllArtistsDOMParser
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc=new XmlDocument();
            doc.Load("../../../catalogue.xml");            

            Dictionary<string,int> artistsWithNumberOfAlbums=new Dictionary<string, int>();
            XmlNodeList artists=doc.GetElementsByTagName("artist");

            foreach (XmlElement artist in artists)
            {
                if (artistsWithNumberOfAlbums.ContainsKey(artist.InnerText))
                {
                    artistsWithNumberOfAlbums[artist.InnerText] += 1;
                }
                else
                {
                    artistsWithNumberOfAlbums.Add(artist.InnerText,1);
                }
            }

            foreach (var artist in artistsWithNumberOfAlbums)
            {
                Console.WriteLine("{0} - {1} albums",artist.Key,artist.Value);
                
            }
        }
    }
}
