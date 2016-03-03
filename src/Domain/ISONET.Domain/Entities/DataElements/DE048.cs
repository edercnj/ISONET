using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE048 : DataElement
    {
        //Custom Data Element
        private DE048(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 048;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        private DE048(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 048;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        private DE048(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 048;
            Name = "additional data - private";
            Value = value;
        }

        private DE048(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999);
            ConditionUse = conditionUse;
            Bit = 048;
            Name = "additional data - private";
        }

        private DE048(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 048;
            Name = "additional data - private";
            Value = value;
        }

        private DE048(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 999, length);
            ConditionUse = conditionUse;
            Bit = 048;
            Name = "additional data - private";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}