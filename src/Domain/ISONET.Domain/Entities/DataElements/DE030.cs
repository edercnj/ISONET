using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE030 : DataElement
    {
        //Custom Data Element
        public DE030(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 030;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE030(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 030;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE030(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 24);
            ConditionUse = conditionUse;
            Bit = 030;
            Name = "amounts, original";
            Value = value;
        }

        public DE030(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 24);
            ConditionUse = conditionUse;
            Bit = 030;
            Name = "amounts, original";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}