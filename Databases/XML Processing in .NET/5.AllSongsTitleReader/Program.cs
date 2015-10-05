﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AllSongsTitle
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("../../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine("Song title:{0} ",reader.ReadElementString());
                    }

                }
            }
        }
    }
}
