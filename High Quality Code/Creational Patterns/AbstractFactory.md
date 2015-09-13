## Abstract Factory Pattern ##
###Intent
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
A hierarchy that encapsulates: many possible "platforms", and the construction of a suite of "products".

Provide a level of indirection that abstracts the creation of families of related or dependent objects without directly specifying their concrete classes. The "factory" object has the responsibility for providing creation services for the entire platform family. Clients never create platform objects directly, they ask the factory to do that for them.

This mechanism makes exchanging product families easy because the specific class of the factory object appears only once in the application - where it is instantiated. The application can wholesale replace the entire family of products simply by instantiating a different concrete instance of the abstract factory.

Because the service provided by the factory object is so pervasive, it is routinely implemented as a Singleton
##Class diagram##

![](abstractFactory.png)

###### Abstract Factory
~~~c#

namespace AbstractFactory.Computers
{
    public abstract class Computer
    {
        private IEnumerable<string> components;

        protected Computer(IEnumerable<string> components)
        {
            this.components = new List<string>(components);
        }

        public IEnumerable<string> Components
        {
            get
            {
                return this.components;
                
            }
        }

        public abstract string Seller { get; }


    }
}
~~~
~~~c#
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
~~~

~~~c#
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
~~~

~~~c#
namespace AbstractFactory.Factories
{
    using AbstractFactory.Computers;

    public class Amazon : Seller
    {
        private const string SellerName = "Amazon";

        public override HP SaleHP()
        {
            var components = new List<string> {"mouse", "speakers"};
            var computer=new HP(components,SellerName);
            return computer;
        }

        public override Toshiba SaleToshiba()
        {
            var components = new List<string> { "mouse"};
            var computer = new Toshiba(components, SellerName);
            return computer;
        }
    }
}

~~~

~~~c#
namespace AbstractFactory.Factories
{
    using System.Collections.Generic;

    using AbstractFactory.Computers;

    public class BestBuy : Seller
    {

        private const string SellerName = "Best buy";

        public override HP SaleHP()
        {
            var components = new List<string> { "HDD", "speakers" };
            var computer = new HP(components, SellerName);
            return computer;
        }

        public override Toshiba SaleToshiba()
        {
            var components = new List<string> { "HDD" ,"mouse"};
            var computer = new Toshiba(components, SellerName);
            return computer;
        }
    }
}
~~~

~~~c#
namespace AbstractFactory.Factories
{
    using AbstractFactory.Computers;

    public abstract class Seller
    {
        public abstract HP SaleHP();

        public abstract Toshiba SaleToshiba();
    }
}
~~~
