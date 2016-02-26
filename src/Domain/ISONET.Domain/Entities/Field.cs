using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Field : IField
    {
        public Field(int position, int length, LengthType lengthType, FieldType fieldType, string propertyName)
        {
            Position = position;
            Length = length;
            LengthType = lengthType;
            FieldType = fieldType;
            PropertyName = propertyName;
        }

        public int Position { get; set; }
        public int Length { get; set; }
        public LengthType LengthType { get; set; }
        public FieldType FieldType { get; set; }
        public string PropertyName { get; set; }
    }
}