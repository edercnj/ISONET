using ISONET.Domain.Interfaces.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
    public class DataElement : IDataElement
    {
        public DataElement(IAttribute attribute, short bit, IRule rule, string description, string name, IList<IDataObject> dataObjects)
        {
            Attribute = attribute;
            Bit = bit;
            Rule = rule;
            Description = description;
            Name = name;
            DataObjects = dataObjects;
        }

        public DataElement(IAttribute attribute, short bit, IRule rule, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            Rule = rule;
            Description = description;
            Name = name;
        }

        public IAttribute Attribute { get; }
        public short Bit { get; }
        public IRule Rule { get; }
        public string Description { get; set; }
        public string Name { get; }
        public IList<IDataObject> DataObjects { get; set; }

        public override string ToString()
        {
            return DataObjects.Aggregate(string.Empty, (current, data) => current + data.Value);
        }

        public string toTypeLengthValue()
        {
            return DataObjects.Aggregate(string.Empty, (current, data) => current + data.toTypeLengthValue());
        }
    }
}