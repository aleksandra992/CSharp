using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Items
{
    public class Book : Item
    {
        public Book(float weight,string title)
            : base(weight)
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }
}
