using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
    public static class ValueMask
    {
        public static bool IsMonth(this string value) => Regex.IsMatch(value, @"^(1[0-2]|0[1-9])$");

        public static bool IsDay(this string value) => Regex.IsMatch(value, @"^(3[01]|[12][0-9]|0[1-9])$");

        public static bool IsYear(this string value) => Regex.IsMatch(value, @"^(19|20)[0-9]{2}$");

        public static bool IsHour(this string value) => Regex.IsMatch(value, @"^(2[0-3]|0[0-9]|1[0-9])$");

        public static bool IsMinute(this string value) => Regex.IsMatch(value, @"^([1-5][0-9]|0[0-9])$");

        public static bool IsSecond(this string value) => Regex.IsMatch(value, @"^([1-5][0-9]|0[0-9])$");
    }
}