using System;
using System.Globalization;

namespace OOPLearningV1
{
    internal class Calendar
    {
        public static void isLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
            return;
        }

        //Get info about current date and time then return a string
        public string GetCurrentDateTime()
        {
            DateTime todayTime = DateTime.Now;
            string result = todayTime.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"));
            return result;
        }

        //Get current day of week
        public string GetDayOfWeekToday()
        {
            //To get the day in English
            DateTime todayTime = DateTime.Now;
            //string result = todayTime.DayOfWeek.ToString();

            //To get the day in German
            CultureInfo german = new CultureInfo("de-DE");
            string result = german.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            return result;
        }

        public string GetUpTime()
        {
            TimeSpan upTime = new TimeSpan();
            upTime = TimeSpan.FromMilliseconds(Environment.TickCount);
            string result = upTime.ToString("%d") + " day(s), " + upTime.ToString("%h") + " hours, " + upTime.ToString("%m") + " minutes, " + upTime.ToString("%s") + " seconds.";
            return result;
        }
    }
}