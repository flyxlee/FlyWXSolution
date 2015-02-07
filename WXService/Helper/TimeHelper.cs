using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WXService.Helper
{
    public class TimeHelper
    {
        public static bool IsWorkingDay(string workingDayAM, string workingDayPM, List<string> weekend)
        {
            TimeSpan am = DateTime.Parse(workingDayAM).TimeOfDay;
            TimeSpan pm = DateTime.Parse(workingDayPM).TimeOfDay;
            string weekDay = DateTime.Now.DayOfWeek.ToString();
            for (int i = 0; i < weekend.Count; i++)
            {
                if (weekDay.Equals(weekend[i]))
                {
                    return false;
                }
            }
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= am && now <= pm)
            {
                return true;
            }
            return false;
        }
    }
}
