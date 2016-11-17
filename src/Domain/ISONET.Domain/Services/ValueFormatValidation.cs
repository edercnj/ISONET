using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Services
{
    //TODO: Implementar correta verificação de binary(valor HEXADECIMAL). Atualmente quando usado Binary ele pode ser interpretado com numérico ou alfabético.
    public static class ValueFormatValidation
    {
        public static bool FormatIsValid(IDataElement dataElement) => ValueFormatIsValid(dataElement);

        private static bool ValueFormatIsValid(IDataElement dataElement)
        {
            var isValid = true;
            IEnumerable<AttributeFormat> valueAttributes = ValueToAttributeFormat(dataElement.ToString()).ToList();
            var dataElementAttributes = dataElement.DataElementAttribute.AttributeFormat.ToList();

            foreach (AttributeFormat att in valueAttributes)
            {
                var contais = false;

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

        private static IEnumerable<AttributeFormat> ValueToAttributeFormat(string value)
        {
            var attributeFormat = new List<AttributeFormat>();

            if (value.ContainsSpaceAndPad())
                attributeFormat.Add(AttributeFormat.Space);
            if (value.ContainsSpecialCharacter())
                attributeFormat.Add(AttributeFormat.Special);
            if (value.ContainsAlphabetical())
                attributeFormat.Add(AttributeFormat.Alphabetical);
            if (value.ContainsNumeric())
                attributeFormat.Add(AttributeFormat.Numeric);
            if (value.IsXFormat())
                attributeFormat.Add(AttributeFormat.X);

            return attributeFormat;
        }
    }
}