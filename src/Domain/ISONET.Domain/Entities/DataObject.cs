using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    public class DataObject : IDataObject
    {
        public DataObject(string type, int length, object value)
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

        public DataObject(string type)
        {
            Type = type;
        }

        public string Type { get; set; }

        public int Length { get; set; }

        public object Value
        {
            get { return Value.ToString(); }
            set { Value = value; }
        }

        public string toTypeLengthValue()
        {
            return Type + Length + Value;
        }
    }
}