using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
    public static class AttributeFormatValidation
    {
        public static bool ContainsNumeric(this string value)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsAlphabetical(this string value)
        {
            Regex regex = new Regex(@"(?i)[a-z]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsSpecialCharacter(this string value)
        {
            Regex regex = new Regex(@"(?i)[^-\sa-z0-9]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsSpaceAndPad(this string value)
        {
            Regex regex = new Regex(@"(?i)[-\s]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool IsBinary(this string value)
        {
            return Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        public static bool isXFormat(this string value)
        {
            return Regex.IsMatch(value, @"^(C|D)");
        }
    }
}