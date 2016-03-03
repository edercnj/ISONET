using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE113 : DataElement
    {
        //Custom Data Element
        public DE113(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 113;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE113(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 113;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE113(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 113;
            Name = "reserved for IS0 use";
            Value = value;
        }

        public DE113(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 113;
            Name = "reserved for IS0 use";
        }

        public DE113(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 113;
            Name = "reserved for IS0 use";
            Value = value;
        }

        public DE113(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 113;
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