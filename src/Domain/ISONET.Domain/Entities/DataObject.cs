using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    /// <summary>
    ///     TLV Data Object
    /// </summary>
    public class DataObject : IDataObject
    {
        public DataObject(int length, string type, object value)
        {
            Length = length;
            Type = type;
            Value = value;
        }

        public DataObject(string type)
        {
            Type = type;
        }

        public string Type { get; set; }

        public int Length { get; set; }

        public object Value { get; set; }

        public override string ToString()
        {
            return Type + Length + Value;
        }
    }
}