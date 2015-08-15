using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    public class Report : IContentProvider
    {
        private Ilogger logger;
        public string Header { get; set; }

        public string Content { get; set; }

        public string Footer { get; set; }

        public Report(Ilogger logger)
        {
            this.logger = logger;

        }

        public Report()
            : this(new ConsoleLogger())
        {

        }

        public void LoadReport()
        {
            this.Header = "header";
            this.Content = "content";
            this.Footer = "footer";
            this.logger.LogLine("report loaded");
        }

        public string ProvideContent()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(this.Header);
            stringBuilder.AppendLine(this.Content);
            stringBuilder.AppendLine(this.Footer);
            return stringBuilder.ToString();

        }
    }
}
