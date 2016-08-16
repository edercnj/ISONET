using System.Text.RegularExpressions;

namespace ISONET.Domain.Services
{
	public static class AttributeFormatValidation
	{
		public static bool ContainsNumeric(this string value) => Regex.IsMatch(value, @"[0-9]");

		public static bool ContainsAlphabetical(this string value) => Regex.IsMatch(value, @"(?i)[a-z]");

		public static bool ContainsSpecialCharacter(this string value) => Regex.IsMatch(value, @"(?i)[^-\sa-z0-9]");

		public static bool ContainsSpaceAndPad(this string value) => Regex.IsMatch(value, @"(?i)[-\s]");

		public static bool IsBinary(this string value) => Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z");

		public static bool IsXFormat(this string value) => Regex.IsMatch(value, @"^(C|D)");
	}
}