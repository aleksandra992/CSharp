using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtToXML
{
    public class Person
    {
        public Person(string name,string address,string phone)
        {
            this.Name = name;
            this.Address=address;
            this.Phone = phone;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
