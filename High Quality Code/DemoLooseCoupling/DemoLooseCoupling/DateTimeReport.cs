using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class DateTimeReport:IContentProvider
    {
        public string ProvideContent()
        {
            var content = DateTime.Now.ToString();
            return content;

        }
    }
}
