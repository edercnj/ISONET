using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class Field : IField
    {
        public Field(int position, int length, object value)
        {
            Value = value;
            Position = position;
            Length = length;
        }

        public int Position { get; set; }
        public int Length { get; set; }
        public object Value { get; set; }
    }
}