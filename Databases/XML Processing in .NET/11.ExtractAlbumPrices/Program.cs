using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _11.ExtractAlbumPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc=new XmlDocument();
            xmlDoc.Load("../../../catalogue.xml");
            string xPathQuery = String.Format("/catalogue/album[year<{0}]", DateTime.Now.Year - 5);
            XmlNodeList albums = xmlDoc.SelectNodes(xPathQuery);
            foreach (XmlNode album in albums)
            {
                Console.WriteLine("The album {0} is published 5 years ago or earlier and has price of ",album["name"].InnerText,album["price"].InnerText);
            }
        }
    }
}
