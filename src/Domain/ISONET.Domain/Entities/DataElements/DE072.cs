using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE072 : DataElement
    {
        //Custom Data Element
        public DE072(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE072(IAtrribute attribute, short bit, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = bit;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE072(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 0072;
            Name = "data record";
            Value = value;
        }

        public DE072(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 0072;
            Name = "data record";
        }

        public DE072(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 0072;
            Name = "data record";
            Value = value;
        }

        public DE072(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 0072;
            Name = "data record";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}