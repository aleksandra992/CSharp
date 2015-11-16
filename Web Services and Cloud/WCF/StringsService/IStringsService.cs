namespace Strings
{
    using System.ServiceModel;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStringsService
    {
        [OperationContract]
        int GetNumberOfTimesSecondStringContainsInFirstString(string first, string second);
    }
}
