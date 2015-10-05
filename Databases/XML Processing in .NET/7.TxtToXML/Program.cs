using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TxtToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string address;
            string phone;
            using (StreamReader reader = new StreamReader("../../Person.txt"))
            {
                name = reader.ReadLine();
                address = reader.ReadLine();
                phone = reader.ReadLine();
            }
            var person = new Person(name, address, phone);
            XElement doc = new XElement("student",
             new XElement("name", person.Name),
            new XElement("address", person.Address),
            new XElement("phone", person.Phone));

            doc.Save("../../newCatalogue.xml");
            Console.WriteLine("The Xml is saved in newCatalogue.xml file");
        }
    }
}
