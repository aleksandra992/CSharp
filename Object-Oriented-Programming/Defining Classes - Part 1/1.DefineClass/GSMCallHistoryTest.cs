using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
   static class GSMCallHistoryTest
    {
       
     
        public static void TestHistory()        {
            GSM mobilePhone = new GSM("HTC one", "HTC", 450, "GC", new Battery("NiMH"), BatteryType.NiMH, new Display(4));
            mobilePhone.AddCalls(new Call(DateTime.Now, "00359888445566", 50));
            mobilePhone.AddCalls(new Call(new DateTime(2015, 05, 25), "888882144455", 250));
            mobilePhone.AddCalls(new Call(new DateTime(2014, 06, 27), "22222244455", 45));
            mobilePhone.AddCalls(new Call(new DateTime(2013, 05, 16), "5145521455", 500));
            foreach (var item in mobilePhone.CallHistory)
            {
                Console.WriteLine(item.ToString());
            }

           Console.WriteLine("The price of all the calls is{0}", mobilePhone.Callprice(0.37));
         
          
           Call c = mobilePhone.CallHistory.OrderByDescending(x => x.Duration).FirstOrDefault();
           Console.WriteLine("The longest call: {0} ", c.ToString());
           mobilePhone.DeleteCalls(mobilePhone.CallHistory.OrderByDescending(x => x.Duration).FirstOrDefault());
           Console.WriteLine("The price of all the calls without the longest is {0}", mobilePhone.Callprice(0.37));
           mobilePhone.DeleteCallHistory();
        }
    }
}
