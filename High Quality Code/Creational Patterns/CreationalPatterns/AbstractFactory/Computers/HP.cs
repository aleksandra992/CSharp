namespace AbstractFactory.Computers
{
    using System;
    using System.Collections.Generic;
    


    public class HP : Computer
    {
        private string seller;

        public HP(IEnumerable<string> components, string seller)
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
