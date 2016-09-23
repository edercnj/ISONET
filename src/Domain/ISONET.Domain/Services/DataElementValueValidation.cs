using System.Collections.Generic;
using System.Linq;
using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
	//TODO: Implementar correta verificação de binary(valor HEXADECIMAL). Atualmente quando usado Binary ele pode ser interpretado com numérico ou alfabético.
	public static class DataElementValueValidation
	{
		public static bool ValueIsValid(this IDataElement dataElement)
		{
			return dataElement.ValueFormatIsValid() && dataElement.ValueLengthIsValid();
		}

		private static bool ValueFormatIsValid(this IDataElement dataElement)
		{
			bool isValid = true;
			IEnumerable<AttributeFormat> valueAttributes = dataElement.ToString().ValueToAttributeFormat().ToList();
			List<AttributeFormat> dataElementAttributes = dataElement.Attribute.AttributeFormat.ToList();

			foreach (AttributeFormat att in valueAttributes)
			{
				bool contais = false;

				foreach (AttributeFormat deAtt in dataElementAttributes)
				{
					if ((int)att == (int)deAtt)
						contais = true;
				}

				if (contais == false)
				{
					isValid = false;
					break;
				}
			}

			return isValid;
		}

		private static IEnumerable<AttributeFormat> ValueToAttributeFormat(this string value)
		{
			List<AttributeFormat> valueAttributes = new List<AttributeFormat>();

			if (value.ContainsSpaceAndPad())
				valueAttributes.Add(AttributeFormat.SPACE);
			if (value.ContainsSpecialCharacter())
				valueAttributes.Add(AttributeFormat.SPECIAL);
			if (value.ContainsAlphabetical())
				valueAttributes.Add(AttributeFormat.ALPHABETICAL);
			if (value.ContainsNumeric())
				valueAttributes.Add(AttributeFormat.NUMERIC);
			if (value.IsXFormat())
				valueAttributes.Add(AttributeFormat.X);

			return valueAttributes;
		}

		private static bool ValueLengthIsValid(this IDataElement dataElement)
		{
			bool isvalid = dataElement.Value.Length <= dataElement.Attribute.Length;

			return isvalid;
		}
	}
}