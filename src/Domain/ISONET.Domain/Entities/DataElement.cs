using ISONET.Domain.Interfaces.Entities;
using System;

namespace ISONET.Domain.Entities
{
    public class DataElement : IDataElement
    {
        public DataElement(IAttribute attribute, short bit, IRule conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DataElement(IAttribute attribute, short bit, IRule conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public IAttribute Attribute { get; }
        public short Bit { get; }
        public IRule ConditionUse { get; }
        public string Description { get; set; }
        public string Name { get; }
        public object Value { get; set; }

        public override string ToString()
        {
            string value = string.Empty;

            switch (Attribute.LengthType)
            {
                case LengthType.LLLVAR:
                    value = Convert.ToString(Value.ToString().Length.ToString("D3")) + Value;
                    break;

                case LengthType.LLVAR:
                    value = Convert.ToString(Value.ToString().Length.ToString("D3")) + Value;
                    break;

                case LengthType.FIXED:
                    value = Value.ToString();
                    break;
            }

            return value;
        }
    }
}