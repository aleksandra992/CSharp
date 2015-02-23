using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidays = new List<DateTime>() { 
            new DateTime(2015,1,1),
            new DateTime(2015,3,3),
            new DateTime(2015,4,10),new DateTime(2015,4,13),
            new DateTime(2015,5,1),new DateTime(2015,5,6),
            new DateTime(2015,5,24),new DateTime(2015,9,6),
            new DateTime(2015,9,22),
            new DateTime(2015,12,24),new DateTime(2015,12,25),
            new DateTime(2015,12,26)
            };
            int workDays = 0;
           
            DateTime startDate = DateTime.Now;
            Console.WriteLine("enter the date to which you want to count working days in format dd.MM.YYYY");
            DateTime endDAte = DateTime.Parse(Console.ReadLine());
            DateTime dateNow = DateTime.Now;
            dateNow = dateNow.AddDays(6);
            DateTime currentDate=startDate;
            bool isHoliday=false;
            int br = (int)dateNow.DayOfWeek;
            int dayOfWeek=0;
            while (currentDate <= endDAte)
            {
                isHoliday=holidays.Contains(startDate);
                dayOfWeek=(int)currentDate.DayOfWeek;
                if ( !isHoliday && dayOfWeek!=0 && dayOfWeek!=6)
                {
                    workDays++;
                }
                currentDate = currentDate.AddDays(1);
            }
            Console.WriteLine("There are {0} working days", workDays);

        }
    }
}
