using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
