using System;

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
    }
}