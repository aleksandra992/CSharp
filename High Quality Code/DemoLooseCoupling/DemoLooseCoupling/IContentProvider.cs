using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    public interface IContentProvider
    {
        string ProvideContent();
    }
}
