using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TraversingDirectoryXDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirPath = "E:\\Git hub\\Telerik Academy\\Databases";
            var element = new XElement("directories",WriteTraversingElements(dirPath));
            element.Save("../../directories.xml");

        }
        static XElement WriteTraversingElements(string directory)
        {
            var dirs = Directory.GetDirectories(directory);
            var files = Directory.GetFiles(directory);
            XElement element = new XElement("dir", new XAttribute("path", directory));
            foreach (var dir in dirs)
            {
                element.Add(WriteTraversingElements(dir));
            }

            foreach (var file in files)
            {
                element.Add(new XElement("file",
                    new XElement("name", file)));
            }
            return element;
        }
    }
}
