namespace DayOFWeekHost
{
    using System;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using DayOfWeek;

    public class Program
    {
        public static void Main(string[] args)
        {
            Uri serviceaddress = new Uri("http://localhost:1229/DayOfWeek");
            ServiceHost selfHost = new ServiceHost(typeof(DayOfWeekService), serviceaddress);

            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);
            //(selfHost.Description.Behaviors.FirstOrDefault(x => x is ServiceDebugBehavior) as ServiceDebugBehavior)
            //   .IncludeExceptionDetailInFaults = true;


            selfHost.Open();
            Console.WriteLine("Servie started on {0}", serviceaddress);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
