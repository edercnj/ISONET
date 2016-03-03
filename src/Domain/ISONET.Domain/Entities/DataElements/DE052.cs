using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE052 : DataElement
    {
        //Custom Data Element
        public DE052(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 052;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE052(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 052;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE052(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 052;
            Name = "personal identification number (PIN) data";
            Value = value;
        }

        public DE052(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 052;
            Name = "personal identification number (PIN) data";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}