using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringsClient = new StringsServiceClient();
            stringsClient.GetNumberOfTimesSecondStringContainsInFirstStringAsync("aaa", "aaabaaabaaa")
                .ContinueWith(
                    Result =>
                    {
                        var result = Result.Result;
                        Console.WriteLine(result);
                    });
            Console.ReadLine();

        }
    }
}
