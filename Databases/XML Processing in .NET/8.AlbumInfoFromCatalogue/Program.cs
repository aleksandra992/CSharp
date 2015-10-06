using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _8.AlbumInfoFromCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlWriter writer = XmlWriter.Create("../../albums.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist",reader.ReadElementString());
                                writer.WriteEndElement();
                            }

                        }
                    }
                }
                writer.WriteEndElement();
            }
            Console.WriteLine("The albums info is saved in albums.xml file");
         
        }
       
    }
}
