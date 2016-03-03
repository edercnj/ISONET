using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE054 : DataElement
    {
        //Custom Data Element
        public DE054(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 054;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE054(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 054;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE054(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 120);
            ConditionUse = conditionUse;
            Bit = 054;
            Name = "amounts, additional";
            Value = value;
        }

        public DE054(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 120);
            ConditionUse = conditionUse;
            Bit = 054;
            Name = "amounts, additional";
        }

        public DE054(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 120, length);
            ConditionUse = conditionUse;
            Bit = 054;
            Name = "amounts, additional";
            Value = value;
        }

        public DE054(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 120, length);
            ConditionUse = conditionUse;
            Bit = 054;
            Name = "amounts, additional";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}