using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;

namespace ISONET.Application
{
    public static class DataElementAttributeApplication
    {
        public static IDataElementAttribute CreateDataElementAttribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength)
        {
            IDataElementAttribute dataElementAttribute = new DataElementAttribute(attributeFormat, lengthType, attributeMask, maxLength);

            return dataElementAttribute;
        }

        public static IDataElementAttribute CreateDataElementAttribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength, short length)
        {
            IDataElementAttribute dataElementAttribute = new DataElementAttribute(attributeFormat, lengthType, attributeMask, maxLength, length);

            return dataElementAttribute;
        }
    }
}