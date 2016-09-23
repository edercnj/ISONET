using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class DataObject : IDataObject
    {
        public DataObject(string type, int length, string value)
        {
            Length = length;
            Type = type;
            Value = value;
        }

        public DataObject(string type, int length)
        {
            Length = length;
            Type = type;
        }

        public string Type { get; set; }
        public int Length { get; set; }
        public string Value { get; set; }

        public string toTypeLengthValue()
        {
            return Type + Length + Value;
        }
    }
}