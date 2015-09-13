using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Computers
{
    public class Toshiba : Computer
    {
        private string seller;

        public Toshiba(IEnumerable<string> components, string seller)
            : base(components)
        {
            this.seller = seller;
        }


        public override string Seller
        {
            get { return String.Format("The seller is {0}", this.seller); }
        }
    }
}
