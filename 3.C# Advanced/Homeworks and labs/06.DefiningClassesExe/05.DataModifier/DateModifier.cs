using System;

namespace _05.DataModifier
{
    public static class DateModifier
    {
        public static int GetDaysOfTwoDates(string one, string two)
        {
            DateTime firstDate = DateTime.Parse(one);
            DateTime secondDate = DateTime.Parse(two);

            TimeSpan days = firstDate - secondDate;
            return Math.Abs(days.Days);
        }
    }
}
