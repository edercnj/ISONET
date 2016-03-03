using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE118 : DataElement
    {
        //Custom Data Element
        public DE118(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 118;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE118(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 118;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE118(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = "reserved for national use";
            Value = value;
        }

        public DE118(IConditionUse conditionUse, object value, string name)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = name;
            Value = value;
        }

        public DE118(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = "reserved for national use";
        }

        public DE118(IConditionUse conditionUse, string name)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = name;
        }

        public DE118(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = "reserved for national use";
            Value = value;
        }

        public DE118(IConditionUse conditionUse, object value, string name, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = name;
            Value = value;
        }

        public DE118(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = "reserved for national use";
        }

        public DE118(IConditionUse conditionUse, string name, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 118;
            Name = name;
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}