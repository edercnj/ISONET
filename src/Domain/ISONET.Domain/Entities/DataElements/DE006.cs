using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE006 : DataElement
    {
        //Custom  Data Element
        public DE006(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 006;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom  Data Element
        public DE006(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 006;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE006(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 006;
            Name = "amount, cardholder billing";
            Value = value;
        }

        public DE006(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 12);
            ConditionUse = conditionUse;
            Bit = 006;
            Name = "amount, cardholder billing";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}