using ISONET.Domain.Interfaces.Entities;
using System;

namespace ISONET.Domain.Entities
{
    public class DataElement : IDataElement
    {
        public DataElement(IAtrribute attribute, short bit, IConditionUse conditionUse, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Name = name;
        }

        public DataElement(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DataElement(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public IAtrribute Attribute { get; }
        public short Bit { get; }
        public IConditionUse ConditionUse { get; }
        public string Description { get; set; }
        public string Name { get; }

        public object Value { get; set; }

        // TODO: Verificar a melhor forma de armazenar o valor para os tipos LLVAR e LLLVAR.
        public override string ToString()
        {
            string value = string.Empty;
            switch (Attribute.LengthType)
            {
                case LengthType.LLLVAR:
                    value = Convert.ToString(Value.ToString().Length) + Value;
                    break;

                case LengthType.LLVAR:
                    value = Convert.ToString(Value.ToString().Length) + Value;
                    break;

                case LengthType.FIXED:
                    break;
            }

            return value;
        }
    }
}