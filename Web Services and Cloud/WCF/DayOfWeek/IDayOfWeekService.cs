namespace DayOfWeek
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDayOfWeekService
    {
        [OperationContract]
        string GetDayInBulgarian(DateTime inputDateTime);
    }
}
