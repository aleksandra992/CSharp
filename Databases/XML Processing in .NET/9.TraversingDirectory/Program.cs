using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TraversingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "E:\\Git hub\\Telerik Academy\\Databases";
           
            using (XmlTextWriter writer = new XmlTextWriter("../../directories.xml",Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("directories");
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dirPath);
                WriteTraversingElements(dirPath,writer);
                writer.WriteEndElement();
            }
            Console.WriteLine("The directories are stored in directories.xml file");

        }

        static void WriteTraversingElements(string directory, XmlWriter writer)
        {
            var dirs = Directory.GetDirectories(directory);
            var files = Directory.GetFiles(directory);
            foreach (var dir in dirs)
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path",dir);
                WriteTraversingElements(dir,writer);
                writer.WriteEndElement();

            }

            foreach (var file in files)
            {
                writer.WriteStartElement("file");
                writer.WriteElementString("name",file);
                writer.WriteEndElement();
            }
        }
    }
}
