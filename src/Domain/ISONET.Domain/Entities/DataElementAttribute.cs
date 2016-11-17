using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class DataElementAttribute : IDataElementAttribute
    {
        private IEnumerable<AttributeFormat> _attributeFormat;
        private IEnumerable<AttributeMask> _attributeMask;
        private LengthType _lengthType;
        private short _maxLength;
        private short _length;

        public DataElementAttribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength)
        {
            AttributeFormat = attributeFormat;
            LengthType = lengthType;
            AttributeMask = attributeMask;
            MaxLength = maxLength;
            Length = MaxLength;
        }

        public DataElementAttribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength, short length) : this(attributeFormat, lengthType, attributeMask, maxLength)
        {
            Length = length;
        }

        public IEnumerable<AttributeFormat> AttributeFormat
        {
            get { return _attributeFormat; }
            private set
            {
                _attributeFormat = value.Distinct();
            }
        }

        public IEnumerable<AttributeMask> AttributeMask
        {
            get { return _attributeMask; }
            private set
            {
                _attributeMask = value.Contains(Entities.AttributeMask.NoMask)
                    ? new List<AttributeMask> { Entities.AttributeMask.NoMask }
                    : value;
            }
        }

        public LengthType LengthType { get { return _lengthType; } private set { _lengthType = value; } }

        public short MaxLength { get { return _maxLength; } private set { _maxLength = value; } }

        public short Length { get { return _length; } private set { _length = value; } }
    }
}