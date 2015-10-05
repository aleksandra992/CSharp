using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DeleteAlbumsWithPriceBiggerThan20
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc=new XmlDocument();
            doc.Load("../../../catalogue.xml");
            var root = doc.DocumentElement;
            var albums = doc.GetElementsByTagName("album");
            var albumsToDelete = new List<XmlNode>();
            foreach (XmlElement album in albums)
            {
                var albumPrice = album["price"].InnerText;
                if (double.Parse(albumPrice) > 20)
                {
                    albumsToDelete.Add(album);
                   
                }
            }

            foreach (var album in albumsToDelete)
            {
                root.RemoveChild(album);
                Console.WriteLine("Album {0} has been removed", album["name"].InnerText);
            }

            doc.Save("../../newCatalogue.xml");
        }
    }
}
