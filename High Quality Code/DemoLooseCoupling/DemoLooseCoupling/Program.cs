using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLooseCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report(new ConsoleLogger());
            report.LoadReport();
           ConsolePrinter printer = new ConsolePrinter();
            printer.Print(report);
            DateTimeReport dateTimeReport = new DateTimeReport();
            printer.Print(dateTimeReport);
            

          
            
          
        }
    }
}
