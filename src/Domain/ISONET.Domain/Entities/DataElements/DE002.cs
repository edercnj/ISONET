using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE002 : DataElement
    {
        //Custom  Data Element
        public DE002(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 002;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        //Custom  Data Element
        public DE002(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 002;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE002(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 19);
            ConditionUse = conditionUse;
            Bit = 002;
            Name = "Primary account number";
            Value = value;
        }

        public DE002(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 19);
            ConditionUse = conditionUse;
            Bit = 002;
            Name = "Primary account number";
        }

        public DE002(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 19, length);
            ConditionUse = conditionUse;
            Bit = 002;
            Name = "Primary account number";
            Value = value;
        }

        public DE002(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.NoMask },
                19, length);
            ConditionUse = conditionUse;
            Bit = 002;
            Name = "Primary account number";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}