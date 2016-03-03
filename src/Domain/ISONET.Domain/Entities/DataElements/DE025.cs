using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE025 : DataElement
    {
        //Custom Data Element
        public DE025(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 025;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE025(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 025;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE025(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 4);
            ConditionUse = conditionUse;
            Bit = 025;
            Name = "message reason code";
            Value = value;
        }

        public DE025(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 4);
            ConditionUse = conditionUse;
            Bit = 025;
            Name = "message reason code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}