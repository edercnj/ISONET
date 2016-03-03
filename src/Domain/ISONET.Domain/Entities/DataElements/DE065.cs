using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE065 : DataElement
    {
        //Custom Data Element
        public DE065(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 065;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE065(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 065;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE065(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 065;
            Name = "reserved for IS0 use";
            Value = value;
        }

        public DE065(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 065;
            Name = "reserved for IS0 use";
        }

        public DE065(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8, length);
            ConditionUse = conditionUse;
            Bit = 065;
            Name = "reserved for IS0 use";
            Value = value;
        }

        public DE065(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8, length);
            ConditionUse = conditionUse;
            Bit = 065;
            Name = "reserved for IS0 use";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}