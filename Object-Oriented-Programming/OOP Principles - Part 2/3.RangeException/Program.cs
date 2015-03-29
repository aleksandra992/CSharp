namespace _3.RangeException
{
    using System;
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number in range 1-100");
            int number = int.Parse(Console.ReadLine());
            try
            {
                CheckNumber(number);
                Console.WriteLine("correct number");
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message + " " + ex.Start + "-" + ex.End);
            }
            Console.WriteLine("Enter date between 1.1.1980 and 31.12.2013 in format Year.Month.Day");
            DateTime date = DateTime.Parse(Console.ReadLine());
            try
            {
                CheckDate(date);
                Console.WriteLine("correct date");
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message + " " + ex.Start + "-" + ex.End);
            }

        }

        public static void CheckNumber(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>("The number should be in range", 1, 100);
            }

        }
        public static void CheckDate(DateTime date)
        {
            if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
            {
                throw new InvalidRangeException<DateTime>("Date is invalid!It should be between", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
            }
        }
    }
}
