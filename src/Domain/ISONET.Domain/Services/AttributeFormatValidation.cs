using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
    public static class AttributeFormatValidation
    {
        public static bool ContainsNumeric(string value)
        {
            Regex regex = new Regex(@"[0-9]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsAlphabetical(string value)
        {
            Regex regex = new Regex(@"(?i)[a-z]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsSpecialCharacter(string value)
        {
            Regex regex = new Regex(@"(?i)[^-\sa-z0-9]");
            Match match = regex.Match(value);

            return match.Success;
        }

        public static bool ContainsSpaceAndPad(string value)
        {
            Regex regex = new Regex(@"(?i)[-\s]");
            Match match = regex.Match(value);

            return match.Success;
        }
    }
}