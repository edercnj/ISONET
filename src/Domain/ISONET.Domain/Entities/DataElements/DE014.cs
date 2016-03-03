using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE014 : DataElement
    {
        //Custom  Data Element
        public DE014(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 014;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom  Data Element
        public DE014(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 014;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE014(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM }, 4);
            ConditionUse = conditionUse;
            Bit = 014;
            Name = "date, expiration";
            Value = value;
        }

        public DE014(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM }, 4);
            ConditionUse = conditionUse;
            Bit = 014;
            Name = "date, expiration";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}