using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities
{
    /// <summary>
    /// <para>A data object consists of a tag, a length, and a value. A tag uniquely identifies a data object within the environment of an application.</para>
    /// </summary>
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

        public object Value { get; set; }

        public override string ToString()
        {
            return Type + Length + Value;
        }
    }
}