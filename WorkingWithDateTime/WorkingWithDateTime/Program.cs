using System;
using System.Globalization;
using System.Collections.Generic;
namespace WorkingWithDateTime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Set variable
            DateTimeOffset currentTime = DateTimeOffset.Now;
            DateTimeOffset currentDay = DateTimeOffset.Now.Date;
            DateTimeOffset endTime = new DateTimeOffset();

            Console.WriteLine("Working With DateTime.");
            Console.WriteLine("Current date and time is: {0}.", currentTime.ToString());
            Console.WriteLine("Current date and time is: {0}.", currentDay.ToString("d"));
            //Try to get a valid input
            Console.WriteLine("Please enter a date!");
            string dateInput = Console.ReadLine();
            while (!DateTimeOffset.TryParse(dateInput, null as IFormatProvider, DateTimeStyles.AssumeLocal, out endTime))
            {
                Console.WriteLine("Invalid date format. Please try again!");
                dateInput = Console.ReadLine();
            }
            TimeSpan interval = endTime - currentDay;
            int days = interval.Days;
            Console.WriteLine("From {0} to {1} are {2} days.", currentDay.ToString("d"), endTime.ToString("d"), days);            
            
            int beginYear = currentDay.Year - 1;
            int endYear = endTime.Year;
            int workdays = 0;
            HashSet<DateTimeOffset> holidays = Calendar.GetHolidays(beginYear, endYear);
            for(int i=0; i<=days;i++)
            {
                if(holidays.Contains(currentDay)|| IsWeekend(currentDay))
                {
                    
                }
                else
                {
                    workdays ++;
                }
                currentDay = currentDay.AddDays(1);
            }            
            Console.WriteLine("Workdays: " + workdays);
            /*foreach(DateTimeOffset j in holidays)
            {
                Console.WriteLine(j.ToString());
            }*/
        }

        private static bool IsWeekend(DateTimeOffset day)
        {
            if(day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}