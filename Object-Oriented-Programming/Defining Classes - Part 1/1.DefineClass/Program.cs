using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM mobile = new GSM("samsung s3", "samsung", 400, "SM", new Battery("LiIon"), BatteryType.LiIon, new Display(5.5));
            mobile.BatteryCharacteristic.HoursIdle = 5;
            GSMTest mobilePhones = new GSMTest();
            Console.WriteLine(mobile+"\n");
            Console.WriteLine(mobilePhones.DisplayInformation());
           Console.WriteLine( GSM.iPhone4S.ToString());

           GSMCallHistoryTest.TestHistory();

        }
    }
}
