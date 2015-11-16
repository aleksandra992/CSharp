namespace Client
{
    using System;

    using Client.WeekOfDayServiceReference;
    public class Program
    {
        public static void Main(string[] args)
        {
            var dateClient = new DayOfWeekServiceClient();
            dateClient.GetDayInBulgarianAsync(new DateTime(2015, 11, 15)).ContinueWith(
                dayResult =>
                {
                    var day = dayResult.Result;
                    Console.WriteLine(day);
                });
            Console.WriteLine("Working....");
            Console.ReadLine();
        }
    }
}
