using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DefineClass
{
    class GSMTest
    {
       
       


            GSM[] mobiles ={
                          new GSM("samsung s3","samsung",400,"SM",new Battery("LiIon",5,6),BatteryType.LiIon,new Display(5.5)),
                          new GSM("samsung s5","samsung",500,"AS",new Battery("NiMH"),BatteryType.NiMH,new Display(6))

                      };
           
        
        
   public StringBuilder DisplayInformation()
   {
       StringBuilder info = new StringBuilder();
       foreach (var item in this.mobiles)
       {
          
           info.Append(item.ToString()).Append("\n\n");
       }
       return info;
   }

		 
}
   
}
