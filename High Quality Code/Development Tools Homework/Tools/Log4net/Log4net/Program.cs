using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
namespace Log4net
{
    public class Log4net
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Log4net));

        static void Main(string[] args)
        {

            XmlConfigurator.Configure();
           
            Log.Debug("This is a debug message");
            Log.Warn("This is a warn message");
            Log.Error("This is a error message");
            Log.Fatal("This is a fatal message");
            Console.ReadLine();
        }
    }
}
