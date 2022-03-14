using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
    public static class ValueFormat
    {
        public static bool ContainsNumeric(this string value) => Regex.IsMatch(value, @"[0-9]");

        public static bool ContainsAlphabetical(this string value) => Regex.IsMatch(value, @"(?i)[a-z]");

        public static bool ContainsSpecialCharacter(this string value) => Regex.IsMatch(value, @"(?i)[^-\sa-z0-9]");

        public static bool ContainsSpaceAndPad(this string value) => Regex.IsMatch(value, @"(?i)[-\s]");

        public static bool IsBinary(this string value) => Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z");

        public static bool IsXFormat(this string value) => Regex.IsMatch(value, @"^(C|D)");

        public static bool IsISOTrack(this string value) => IsISOTrack1(value) || IsISOTrack2(value);

        private static bool IsISOTrack2(this string value) => Regex.IsMatch(value, @"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})[=D]([0-9]{2})(1[0-2]|0[1-9])(1|2|5|6|7)(0|2)(0|1|2|3|5|6|7)");

        //TODO:Implenetar validação de trilha 1
        private static bool IsISOTrack1(this string value) => Regex.IsMatch(value, @"^0[1-9]{19}");
    }
}