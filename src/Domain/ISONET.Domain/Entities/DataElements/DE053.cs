using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE053 : DataElement
    {
        public DE053(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 48);
            ConditionUse = conditionUse;
            Bit = 053;
            Name = "security related control information";
            Value = value;
        }

        public DE053(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 48);
            ConditionUse = conditionUse;
            Bit = 053;
            Name = "security related control information";
        }

        public DE053(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 48, length);
            ConditionUse = conditionUse;
            Bit = 053;
            Name = "security related control information";
            Value = value;
        }

        public DE053(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLVAR, new[] { AttributeMask.NoMask }, 48,
                length);
            ConditionUse = conditionUse;
            Bit = 053;
            Name = "security related control information";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}