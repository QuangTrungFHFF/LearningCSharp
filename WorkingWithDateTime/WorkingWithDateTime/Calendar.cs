using System;
using System.Collections.Generic;

namespace WorkingWithDateTime
{
    public class Calendar
    {
        public static HashSet<DateTimeOffset> GetHolidays(int beginYear, int endYear)
        {
            HashSet<DateTimeOffset> holidays = new HashSet<DateTimeOffset>();
            for (int i = beginYear; i <= endYear; i++)
            {
                List<string> fixedHolidays = new List<string>();
                fixedHolidays.Add("01/01/" + i); //New Year
                fixedHolidays.Add("06/01/" + i); //Epiphany
                fixedHolidays.Add("08/03/" + i); //International Women's Day
                fixedHolidays.Add("01/05/" + i); //Labour Day
                fixedHolidays.Add("15/08/" + i); //Assumption Day
                fixedHolidays.Add("03/10/" + i); //Day of German Unity
                fixedHolidays.Add("31/10/" + i); //Reformation Day
                fixedHolidays.Add("01/11/" + i); //All Saints Day
                fixedHolidays.Add("25/12/" + i); //Christmas
                fixedHolidays.Add("26/12/" + i); //Christmas 2nd


                //Add Fixed Holidays
                foreach(string s in fixedHolidays)
                {
                    DateTimeOffset holiDate = DateTimeOffset.Parse(s);
                    holidays.Add(holiDate);
                    holiDate = IsHolidaysOnWeekend(holiDate);
                    holidays.Add(holiDate);
                }
                
                

                //Add Good Friday, Easter Sunday, Easter Monday, Corpus christi,Ascension Day, Whit Sunday, Whit Monday
                holidays.Add(CalcGoodFriday(i));// Good Friday
                holidays.Add(CalcGoodFriday(i).AddDays(2));//Easter Sunday
                holidays.Add(CalcGoodFriday(i).AddDays(3));//Easter Monday
                holidays.Add(CalcGoodFriday(i).AddDays(41));//Ascension Day
                holidays.Add(CalcGoodFriday(i).AddDays(51));//Whit Sunday
                holidays.Add(CalcGoodFriday(i).AddDays(52));//Whit Monday
                holidays.Add(CalcGoodFriday(i).AddDays(62));//Corpus christi


            }
            return holidays;
        }

        public static DateTimeOffset IsHolidaysOnWeekend(DateTimeOffset holiday)
        {
            if (holiday.DayOfWeek == DayOfWeek.Saturday)
            {
                return holiday.AddDays(-1);
            }
            else if (holiday.DayOfWeek == DayOfWeek.Sunday)
            {
                return holiday.AddDays(1);
            }
            else
            {
                return holiday;
            }
        }

        //Get the Good Friday of the year        
        public static DateTimeOffset CalcGoodFriday(int year)
        {
            //int yr = 2010;  // The year for which to determine the date of Good Friday.
            int a = year % 19;
            int b = year / 100;
            int c = year % 100;
            int d = b / 4;
            int e = b % 4;
            int i = c / 4;
            int k = c % 4;
            int g = (8 * b + 13) / 25;
            int h = ((19 * a) + b - d - g + 15) % 30;
            int l = ((2 * e) + (2 * i) - k + 32 - h) % 7;
            int m = (a + (11 * h) + (19 * l)) / 433;
            int days_to_good_friday = h + l - (7 * m) - 2;
            int month = (days_to_good_friday + 90) / 25;
            int day = (days_to_good_friday + (33 * month) + 19) % 32;
            DateTime goodFriday = new DateTime(year, month, day);
            return new DateTimeOffset(goodFriday,TimeZoneInfo.Local.GetUtcOffset(goodFriday)); // Returns the date of Good Friday
        }
    }
}