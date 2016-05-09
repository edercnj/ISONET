using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Attribute : IAttribute
    {
        public Attribute(AttributeFormat[] characterFormat, LengthType lengthType, AttributeMask[] attributeMask, short maxLength)
        {
            AttributeFormat = characterFormat;
            LengthType = lengthType;
            AttributeMask = attributeMask;
            MaxLength = maxLength;
            Length = MaxLength;
        }

        public Attribute(AttributeFormat[] attributeFormat, LengthType lengthType, AttributeMask[] attributeMask, short maxLength, short length)
        {
            AttributeFormat = attributeFormat;
            AttributeMask = attributeMask;
            LengthType = lengthType;
            MaxLength = maxLength;
            Length = lengthType != LengthType.FIXED ? length : maxLength;
        }

        public AttributeFormat[] AttributeFormat { get; }

        public AttributeMask[] AttributeMask { get; }

        public LengthType LengthType { get; }

        public short MaxLength { get; }

        public short Length { get; }
    }
}