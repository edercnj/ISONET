using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class Attribute : IAttribute
    {
        public Attribute(IList<AttributeFormat> attributeFormat, LengthType lengthType, IList<AttributeMask> attributeMask, short maxLength)
        {
            AttributeFormat = attributeFormat;
            LengthType = lengthType;
            AttributeMask = attributeMask;
            MaxLength = maxLength;
            Length = MaxLength;
        }

        public Attribute(IList<AttributeFormat> attributeFormat, LengthType lengthType, IList<AttributeMask> attributeMask, short maxLength, short length)
        {
            AttributeFormat = attributeFormat;
            AttributeMask = attributeMask;
            LengthType = lengthType;
            MaxLength = maxLength;
            Length = lengthType != LengthType.FIXED ? length : maxLength;
        }

        public IList<AttributeFormat> AttributeFormat { get; }

        public IList<AttributeMask> AttributeMask { get; }

        public LengthType LengthType { get; }

        public short MaxLength { get; }

        public short Length { get; }

        public int AttributeFormatToInt(IList<AttributeFormat> att)
        {
            return att.Sum(attr => (int)attr);
        }
    }
}