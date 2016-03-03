using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE034 : DataElement
    {
        //Custom Data Element
        public DE034(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 034;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE034(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 034;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE034(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 28);
            ConditionUse = conditionUse;
            Bit = 034;
            Name = "primary account number, extended";
            Value = value;
        }

        public DE034(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 28);
            ConditionUse = conditionUse;
            Bit = 034;
            Name = "primary account number, extended";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}