using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Services
{
    public static class DataObjectsValidation
    {
        public static bool DataObjectsIsValid(this IDataElement dataElement)
        {
            return dataElement.DataObjectsFormatIsValid();
        }

        private static bool DataObjectsFormatIsValid(this IDataElement dataElement)
        {
            int dataObj = dataElement.ToString().DataObjectAttributeFormatToInt();
            int deattr = dataElement.Attribute.AttributeFormatToInt(dataElement.Attribute.AttributeFormat);

            return (deattr & dataObj) > 0;
        }

        private static int DataObjectAttributeFormatToInt(this string value)
        {
            int alphabetical = value.ContainsAlphabetical() ? (int)AttributeFormat.ALPHABETICAL : 0;
            int numeric = value.ContainsNumeric() ? (int)AttributeFormat.NUMERIC : 0;
            int spaceAndPad = value.ContainsSpaceAndPad() ? (int)AttributeFormat.SPACE : 0;
            int SpecialCharacter = value.ContainsSpecialCharacter() ? (int)AttributeFormat.SPECIAL : 0;
            int binary = value.ContainsSpecialCharacter() ? (int)AttributeFormat.BINARY : 0;
            int xFormat = value.isXFormat() ? (int)AttributeFormat.X : 0;

            return numeric + alphabetical + spaceAndPad + SpecialCharacter + binary + xFormat;
        }
    }
}