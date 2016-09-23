using System.Collections.Generic;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
	public class Attribute : IAttribute
	{
		private IEnumerable<AttributeFormat> _attributeFormat;
		private IEnumerable<AttributeMask> _attributeMask;
		private LengthType _lengthType;
		private short _maxLength;
		private short _length;

		public Attribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength)
		{
			AttributeFormat = attributeFormat;
			LengthType = lengthType;
			AttributeMask = attributeMask;
			MaxLength = maxLength;
			Length = MaxLength;
		}

		public Attribute(IEnumerable<AttributeFormat> attributeFormat, LengthType lengthType, IEnumerable<AttributeMask> attributeMask, short maxLength, short length)
		{
			AttributeFormat = attributeFormat;
			AttributeMask = attributeMask;
			LengthType = lengthType;
			MaxLength = maxLength;
			Length = length;
		}

		public IEnumerable<AttributeFormat> AttributeFormat { get { return _attributeFormat; } private set { _attributeFormat = value; } }

		public IEnumerable<AttributeMask> AttributeMask { get { return _attributeMask; } private set { _attributeMask = value; } }

		public LengthType LengthType { get { return _lengthType; } private set { _lengthType = value; } }

		public short MaxLength { get { return _maxLength; } private set { _maxLength = value; } }

		public short Length { get { return _length; } private set { _length = value; } }
	}
}