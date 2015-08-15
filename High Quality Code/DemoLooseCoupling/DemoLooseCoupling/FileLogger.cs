using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class FileLogger:Ilogger
    {
        private string fileName;

        public FileLogger(string fileName)
        {
            this.fileName = fileName;

        }
        public void LogLine(string line)
        {
            File.AppendAllText(this.fileName, line+Environment.NewLine);
        }
    }
}
