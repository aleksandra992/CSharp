using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class FilePrinter:IPrinter
    {
        private string fileName;
        public FilePrinter(string fileName)
        {
            this.fileName=fileName;

        }
        public void Print(IContentProvider provider)
        {
            var content = provider.ProvideContent();
        
            File.AppendAllText(this.fileName, content+Environment.NewLine);
        }
    }
}
