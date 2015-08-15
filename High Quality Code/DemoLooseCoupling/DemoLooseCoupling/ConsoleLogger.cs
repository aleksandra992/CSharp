using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class ConsoleLogger:Ilogger
    {
        public void LogLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
