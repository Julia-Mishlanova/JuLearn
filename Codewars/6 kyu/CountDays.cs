using System;

namespace DayCount
{
    public class Day
    {
        public string CountDays(DateTime d)
        {
            int daysBetweenDate = (d - DateTime.Now).Days;

            if (daysBetweenDate < 0) return "The day is in the past!";
            if (daysBetweenDate == 0) return "Today is the day!";

            return string.Format("{0} days", daysBetweenDate);
        }
    }
}
